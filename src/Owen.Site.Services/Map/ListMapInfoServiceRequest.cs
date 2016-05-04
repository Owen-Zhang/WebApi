using Owen.Site.Model;
using ServiceStack;

namespace Owen.Site.Services.Map
{
    [Route("/maplist", "GET")]
    public class ListMapInfoServiceRequest : IReturn<MapInfo>
    {

    }
}
