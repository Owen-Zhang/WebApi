using Microsoft.Practices.ServiceLocation;
using SolrNet;
using System;
namespace Owen.Site.Data.Service.Imp
{
    public class SolrDataServiceImp : ISolrDataService
    {
        public object GetOrderByCondition()
        {
            ISolrOperations<SolrOrder> solr = ServiceLocator.Current.GetInstance<ISolrOperations<SolrOrder>>();

            AbstractSolrQuery solrQuery = new SolrQuery("*:*");
            //solrQuery = solrQuery && new SolrQuery(string.Format("name:{0}", "test1"));
            solrQuery = solrQuery && new SolrQuery(string.Format("name:({0} or {1})", "test1", "test6"));
            var result = solr.Query(solrQuery);

            return result;
        }

        public bool SaveOrderToSolr()
        {
            Startup.Init<SolrOrder>("http://localhost:8080/solr/Order2");

            ISolrOperations<SolrOrder> solr = ServiceLocator.Current.GetInstance<ISolrOperations<SolrOrder>>();
            var order = new SolrOrder
            {
                Id = "123459",
                Name = "test9",
                Price = 45.26m
            };
            try
            {
                solr.Add(order);
                solr.Commit();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return true;
        }
    }
}
