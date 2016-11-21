using SolrNet.Attributes;

namespace Owen.Site.Data.Service.Imp
{
    public class SolrOrder
    {
        [SolrUniqueKey("id")]
        public string Id { get; set; }

        [SolrField("name")]
        public string Name { get; set; }

        [SolrField("price")]
        public decimal Price { get; set; }
    }
}
