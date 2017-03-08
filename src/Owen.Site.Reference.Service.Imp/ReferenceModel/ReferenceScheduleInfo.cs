using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owen.Site.Reference.Service.Imp.ReferenceModel
{
    public class ReferenceScheduleInfo
    {
        public int Id { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public int ExitCode { get; set; }

        public int Pid { get; set; }
    }
}
