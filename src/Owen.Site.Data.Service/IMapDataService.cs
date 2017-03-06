using Owen.Site.Core.Common;
using Owen.Site.Model;
using System.Collections.Generic;

namespace Owen.Site.Data.Service
{
    public interface IMapDataService : IDependency
    {
        MapInfo GetMapList();
        List<JobSchedulerInfo> GetJobSchedulerInfoList();
    }
}
