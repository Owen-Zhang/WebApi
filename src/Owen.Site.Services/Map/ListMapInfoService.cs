using System.Collections.Generic;
using Owen.Site.Core.Log;
using Owen.Site.Model;
using Owen.Site.Services.Common;
using Owen.Site.Main.Service;

namespace Owen.Site.Services.Map
{
    public class ListMapInfoService : BaseService<ListMapInfoServiceRequest>
    {
        MapDomainService doMainService;
        public ListMapInfoService(MapDomainService doMainService)
        {
            this.doMainService = doMainService;
        }

        public override object OnGet(ListMapInfoServiceRequest req)
        {
            return new List<MapInfo> { 
                new MapInfo {
                     Address = "成都中和镇",
                     XPoint = "23.2356",
                     YPoint = "106.4586"
                },
                new MapInfo {
                     Address = "成都双流",
                     XPoint = "23.856",
                     YPoint = "106.145"
                }
            };
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
