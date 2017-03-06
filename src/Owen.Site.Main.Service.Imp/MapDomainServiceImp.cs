using Owen.Site.Core.Log;
using Owen.Site.Data.Service;
using Owen.Site.Model;
using Owen.Site.Resouce;
using System.Collections.Generic;

namespace Owen.Site.Main.Service.Imp
{
    public class MapDomainServiceImp : IMapDomainService
    {
        IMapDataService mapDataService;

        public MapDomainServiceImp(IMapDataService mapDataService)
        {
            this.mapDataService = mapDataService;
        }

        public Model.MapInfo GetMapList()
        {
            //LoggerManager.Info(BusinessError._002);
            return mapDataService.GetMapList();
        }

        public List<JobSchedulerInfo> GetJobSchedulerInfoList()
        {
            return mapDataService.GetJobSchedulerInfoList();
        }
    }
}
