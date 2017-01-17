using Owen.Site.Core.Common;
using Owen.Site.Model;

namespace Owen.Site.Data.Service
{
    public interface IMapDataService : IDependency
    {
        MapInfo GetMapList();
    }
}
