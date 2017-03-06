using System;
using Owen.Site.Core.Model;
using System.Collections.Generic;

namespace Owen.Site.Model
{
    public class ScheduleQuery
    {
        public List<int>IdList { get; set; }

        public DateTime? BeginStartTime { get; set; }

        public DateTime? EndStartTime { get; set; }

        public DateTime? BeginOverTime { get; set; }

        public DateTime? EndOverTime { get; set; }

        public PageInfo PageInfo { get; set; }

        public ScheduleQuery() {
            PageInfo = new PageInfo
            {
                PageIndex = 1,
                PageSize = int.MaxValue,
                TotalCount = 0,
                SortStr = string.Empty
            };
        }
    }
}
