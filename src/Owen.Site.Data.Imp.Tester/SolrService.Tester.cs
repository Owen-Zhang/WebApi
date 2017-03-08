using NUnit.Framework;
using Owen.Site.Reference.Service.Imp.Solr;
using Owen.Site.Resouce;
using System;

namespace Owen.Site.Data.Imp.Tester
{
    [TestFixture]
    public class SolrTester
    {
        /*
        [SetUp]
        public void Init()
        {

        }*/

        [Test]
        public void GetSomethingFromSolr()
        {
            /*
            var result = 
            new ScheduleReferenceImp().GetScheduleInfo(new Owen.Site.Model.ScheduleQuery
            {
                IdList = new System.Collections.Generic.List<int> { 1, 2, 930, 1042, 1041 }
            });*/

            var result =
            new ScheduleReferenceImp().GetScheduleInfo(new Owen.Site.Model.ScheduleQuery
            {
                BeginStartTime = DateTime.Now.AddDays(-1),
                EndStartTime = DateTime.Now
            });

            if (result != null)
                result = null;
        }
    }
}
