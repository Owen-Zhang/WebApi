﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owen.Site.Model
{
    public class MapInfo
    {
        public string XPoint { get; set; }

        public string YPoint { get; set; }

        public string Address { get; set; }

        public DoAction Action { get; set; }
    }

    public enum DoAction 
    {
        Common = 0,
        Save = 1,
        Delete = 2
    }
}
