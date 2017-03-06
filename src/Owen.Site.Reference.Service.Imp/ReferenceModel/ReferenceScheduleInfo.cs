using System;
using System.Collections.Generic;
namespace Owen.Site.Reference.Service.Imp.ReferenceModel
{
    public class ScheduleResponse
    {
        public ResponseDetail response { get; set; }
    }

    public class ResponseDetail
    {
        public int numFound { get; set; }

        public int start { get; set; }

        public List<ReferenceScheduleInfo> docs { get; set; }
    }

    public class ReferenceScheduleInfo
    {
        public int Id { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public int ExitCode { get; set; }

        public int Pid { get; set; }
    }
}
