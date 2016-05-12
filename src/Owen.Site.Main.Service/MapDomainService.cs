using Owen.Site.Core.Common;
using Owen.Site.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owen.Site.Main.Service
{
    public interface MapDomainService : IDependency
    {
        MapInfo GetMapList();
    }
}
