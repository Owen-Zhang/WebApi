using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Owen.Site.Core.Auth;
using Owen.Site.Core.Log;
using ServiceStack;
using ServiceStack.Logging;
using ServiceStack.Web;
using ServiceStack.Validation;
using Owen.Site.Core.Common;
using System.Security.Authentication;
using System.Net;
using ServiceStack.FluentValidation;

namespace Owen.Site.Services
{
    public class AppHost : AppHostBase
    {
        public AppHost()
            : base("Owen.Site.API", typeof(AppHost).Assembly)
        {
            
        }

        public override void Configure(Funq.Container container)
        {
            //GlobalRequestFilters.Add(AuthenticationValid);

            GlobalRequestFilters.Add(ValidationFilters.RequestFilter);
            container.RegisterValidators(typeof(AppHost).Assembly);
            container.Adapter = new InterfaceAdapter();

            SetConfig(new HostConfig { 
                DebugMode = false, /*这个可以配制在文件中*/
                EnableFeatures = Feature.All.Remove(
                    Feature.Metadata | Feature.Soap | Feature.Soap11 | Feature.Soap12 | 
                    Feature.Razor | Feature.Csv | Feature.Jsv | Feature.ServiceDiscovery |
                    Feature.Markdown
                )});
            /*Service 内部报错的处理方法*/
            ServiceExceptionHandlers.Add((iReq, reqObj, ex) =>
            {
                LoggerManager.ErrorFormat("{0}\r\nStackTrace: {1}\r\nRequest Body: {2}\r\nUrl: {3}", 
                    ex.Message, ex.StackTrace,
                    ServiceStack.Text.JsonSerializer.SerializeToString(reqObj),
                    iReq.AbsoluteUri);
                return null;
            });


        }

        private void AuthenticationValid(IRequest req, IResponse res, object reqDto)
        {
            IAuthentication authValidater = new Authentication();
            if (!authValidater.Authenticate(req.Headers["Name"], req.Headers["Password"]))
                throw new AuthenticationException("Not Authentication");
                //new HttpError(HttpStatusCode.Unauthorized, "Not Authentication");
        }
    }
}
