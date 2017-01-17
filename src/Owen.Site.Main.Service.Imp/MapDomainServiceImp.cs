using Owen.Site.Core.Log;
using Owen.Site.Data.Service;
using Owen.Site.Resouce;

namespace Owen.Site.Main.Service.Imp
{
    public class MapDomainServiceImp : MapDomainService
    {
        IMapDataService mapDataService;

        public MapDomainServiceImp(IMapDataService mapDataService)
        {
            this.mapDataService = mapDataService;
        }

        public Model.MapInfo GetMapList()
        {
            LoggerManager.Info(BusinessError._002);
            return mapDataService.GetMapList();
        }
    }
}
