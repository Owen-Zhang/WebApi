using Owen.Site.Model;
using ServiceStack;

namespace Owen.Site.Services.Map
{
    [Route("/maplist", "GET")]
    [Route("/map", "POST")]
    //[Route("/other", "POST,GET")]
    public class ListMapInfoServiceRequest : MapInfo
    {
        public string test { get; set; }
    }
}
