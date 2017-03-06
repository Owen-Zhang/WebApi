using Owen.Site.Core.Common;
using Owen.Site.Model;
using System.Collections.Generic;

namespace Owen.Site.Reference.Service.Solr
{
    public interface IScheduleReferenceService : IDependency
    {
        List<ScheduleInfo> GetScheduleInfo(ScheduleQuery info);
    }
}