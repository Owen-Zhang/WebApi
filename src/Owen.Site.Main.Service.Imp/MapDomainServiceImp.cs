using Owen.Site.Data.Service;

namespace Owen.Site.Main.Service.Imp
{
    public class MapDomainServiceImp : MapDomainService
    {
        MapDataService mapDataService;

        public MapDomainServiceImp(MapDataService mapDataService)
        {
            this.mapDataService = mapDataService;
        }

        public Model.MapInfo GetMapList()
        {
            return mapDataService.GetMapList();
        }
    }
}
