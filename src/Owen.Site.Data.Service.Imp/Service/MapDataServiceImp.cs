using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owen.Site.Data.Service.Imp
{
    public class MapDataServiceImp : IMapDataService
    {
        public Model.MapInfo GetMapList()
        {
            return
            new Model.MapInfo {
                Address = "成都中和镇",
                XPoint = "23.2356",
                YPoint = "106.4586"
            };
        }
    }
}
