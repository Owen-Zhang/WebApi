using System;
using Owen.Site.Core.Common;
using Owen.Site.Model;
using System.Collections.Generic;

namespace Owen.Site.Reference.Service.Solr
{
    public interface IScheduleReferenceService : IDependency
    {
        Tuple<List<ScheduleInfo>, int> GetScheduleInfo(ScheduleQuery info);
    }
}