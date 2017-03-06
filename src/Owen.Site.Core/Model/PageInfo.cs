namespace Owen.Site.Core.Model
{
    public class PageInfo
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public int TotalCount { get; set; }

        public string SortStr { get; set; }
    }
}
