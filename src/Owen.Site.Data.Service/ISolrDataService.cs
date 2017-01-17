using Owen.Site.Core.Common;

namespace Owen.Site.Data.Service
{
    public interface ISolrDataService : IDependency
    {
        object GetOrderByCondition();
        bool SaveOrderToSolr();
    }
}
