using System;
using System.Collections.Generic;

namespace Owen.Site.Reference.Service.Imp.ReferenceModel
{
    public class ScheduleResponse<T>
    {
        public ResponseDetail<T> response { get; set; }
    }

    public class ResponseDetail<T>
    {
        public int numFound { get; set; }

        public int start { get; set; }

        public List<T> docs { get; set; }
    }

    public class SolrResponse<T> : ScheduleResponse<T>
    { 
        
    }
}
