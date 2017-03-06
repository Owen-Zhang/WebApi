using Owen.Site.Model;
using ServiceStack;

namespace Owen.Site.Services.BaiduMap
{
    [Route("/maplist", "GET")]
    [Route("/map", "POST")]
    //[Route("/other", "POST,GET")]
    public class MapInfoServiceRequest : MapInfo
    {
        public string test { get; set; }
    }
}
