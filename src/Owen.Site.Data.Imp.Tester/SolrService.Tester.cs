using NUnit.Framework;
using Owen.Site.Reference.Service.Imp.Solr;

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
            new ScheduleReferenceImp().GetScheduleInfo(new Owen.Site.Model.ScheduleQuery
            {
                IdList = new System.Collections.Generic.List<int> { 1, 2, 930, 1042, 1041 }
            });
        }
    }
}
