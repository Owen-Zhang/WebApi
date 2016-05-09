using Owen.Site.Model;
using ServiceStack;

namespace Owen.Site.Services.Map
{
    [Route("/maplist", "GET")]
    [Route("/map", "POST")]
    public class ListMapInfoServiceRequest : MapInfo
    {
    }
}
