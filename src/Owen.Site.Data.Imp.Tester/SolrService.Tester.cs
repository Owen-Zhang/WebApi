﻿using NUnit.Framework;
using Owen.Site.Data.Service.Imp;

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
        public void AddOrderToSolr()
        {
            Assert.AreEqual(1, 2);
            new SolrDataServiceImp().GetOrderByCondition();
        }
    }
}