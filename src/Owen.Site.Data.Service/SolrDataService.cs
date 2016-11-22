using Owen.Site.Core.Common;

namespace Owen.Site.Data.Service
{
    public interface SolrDataService : IDependency
    {
        object GetOrderByCondition();
        bool SaveOrderToSolr();
    }
}
