using System.Collections.Generic;
using Owen.Site.Core.Log;
using Owen.Site.Model;
using Owen.Site.Services.Common;
using Owen.Site.Main.Service;
using Autofac;
using Owen.Site.Core.Common;

namespace Owen.Site.Services.Map
{
    public class ListMapInfoService : BaseService<ListMapInfoServiceRequest>
    {
        public override object OnGet(ListMapInfoServiceRequest req)
        {
            return
            AutofacManager.Current.Container.Resolve<MapDomainService>().GetMapList();
        }

        public override object OnPost(ListMapInfoServiceRequest req)
        {
            return new
            {
                Address = req.Address,
                XPoint = req.XPoint,
                YPoint = req.YPoint
            };
        }
    }
}
