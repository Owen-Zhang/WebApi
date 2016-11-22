using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owen.Site.Data.Imp.Tester
{
    [TestFixture]
    public class MapServiceTester
    {
        [SetUp]
        public void Init()
        { 
        
        }

        [Test]
        public void ShowMapService()
        {
            int i = 10 + 2;

            Assert.AreEqual(i, 1);
        }
    }
}
