using Autofac;
using ServiceStack;
using Owen.Site.Model;
using Owen.Site.Main.Service;
using Owen.Site.Core.Common;
using Owen.Site.Services.Map.Requst;

namespace Owen.Site.Services.Map
{
    public class ListMapInfoService : ServiceStack.Service
    {
        public MapDomainService mapService { get; set; }
        public object Get(ListMapInfoServiceRequest request)
        {
            return mapService.GetMapList();
            //return AutofacManager.GetService<MapDomainService>().GetMapList();
        }

        public object Post(ListMapInfoServiceRequest req)
        {
            //throw new BussinessException("adasdfsdf: {0}".Fmt(req.Address));
            //this.Request.Files[0].SaveTo("path"); save file
            return new
            {
                Address = req.Address,
                XPoint = req.XPoint,
                YPoint = req.YPoint,
                Action = req.Action,
                test = req.test
            };
        }

        // [AddHeader(ContentType = "image/png")]
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
