using Microsoft.Practices.ServiceLocation;
using SolrNet;
namespace Owen.Site.Data.Service.Imp
{
    public class SolrDataServiceImp : SolrDataService
    {
        public object GetOrderByCondition()
        {
            Startup.Init<SolrOrder>("http://localhost:8080/solr/Order2");

            ISolrOperations<SolrOrder> solr = ServiceLocator.Current.GetInstance<ISolrOperations<SolrOrder>>();
            var order = new SolrOrder { 
                Id = "123459",
                Name = "test9",
                Price = 45.26m
            };
            solr.Add(order);
            solr.Commit();

            return null;
        }
    }
}
