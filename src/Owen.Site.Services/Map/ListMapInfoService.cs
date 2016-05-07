using System.Collections.Generic;
using Owen.Site.Core.Log;
using Owen.Site.Model;
using ServiceStack;

namespace Owen.Site.Services.Map
{
    public class ListMapInfoService : Service
    {
        public object Get(ListMapInfoServiceRequest req)
        {
            //FileLog.Instance.InfoFormat("aaaaaaaaa{0}", "111111");
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
    }
}
