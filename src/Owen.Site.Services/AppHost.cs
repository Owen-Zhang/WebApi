using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Owen.Site.Core.Log;
using ServiceStack;
using ServiceStack.Logging;

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
            /*
            ServiceExceptionHandlers.Add((req, reqDto, exception) => {
                return null;
            });
             */
        }
    }
}
