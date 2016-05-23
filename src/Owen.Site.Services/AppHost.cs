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
        }

        private void AuthenticationValid(IRequest req, IResponse res, object reqDto)
        {
            IAuthentication authValidater = new Authentication();
            if (!authValidater.Authenticate(req.Headers["Name"], req.Headers["Password"]))
                throw HttpError.Unauthorized("Not Authentication");
        }
    }
}
