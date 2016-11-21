using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owen.Site.Core.Common
{
    public class BussinessException : ArgumentException
    {
        public BussinessException(string message)
            : this(message, null)
        { 
            
        }

        public BussinessException(string message, Exception innerException)
            : this(message, null, innerException)
        { 
            
        }

        public BussinessException(string message, string paramName, Exception innerException)
            : base(message, paramName, innerException)
        { 
            
        }
    }
}
