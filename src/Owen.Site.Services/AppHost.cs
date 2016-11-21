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
            //Routes.Add<Hello>("/hello", "GET").Add<Hello>("/hello/{Name}", "POST");
            container.Adapter = new InterfaceAdapter();

            SetConfig(new HostConfig { 
                EnableFeatures = Feature.All.Remove(
                    Feature.Metadata | Feature.Soap | Feature.Soap11 | Feature.Soap12 | 
                    Feature.Razor | Feature.Csv | Feature.Jsv | Feature.ServiceDiscovery |
                    Feature.Markdown
                )
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
