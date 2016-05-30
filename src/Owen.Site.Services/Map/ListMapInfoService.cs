using Autofac;
using ServiceStack;
using Owen.Site.Model;
using Owen.Site.Services.Common;
using Owen.Site.Main.Service;
using Owen.Site.Core.Common;
using Owen.Site.Services.Map.Requst;

namespace Owen.Site.Services.Map
{
    public class ListMapInfoService : ServiceStack.Service
    {
        public object Get(ListMapInfoServiceRequest request)
        {
            return AutofacManager.GetService<MapDomainService>().GetMapList();
            //return AutofacManager.Current.Container.Resolve<MapDomainService>().GetMapList();
        }

        public object Post(ListMapInfoServiceRequest req)
        {
            //throw new BussinessException("adasdfsdf: {0}".Fmt(req.Address));
            return new
            {
                Address = req.Address,
                XPoint = req.XPoint,
                YPoint = req.YPoint,
                Action = req.Action
            };
        }

        public object Post(MapInfoReq req)
        {
            return new
            {
                Address = req.Address,
                Action = req.Action
            };
        }
    }
}
