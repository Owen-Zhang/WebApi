using Owen.Site.Services.Common;
using ServiceStack.FluentValidation;

namespace Owen.Site.Services.BaiduMap
{
    public class MapInfoValidator : ValidatorBase<MapInfoServiceRequest>
    {
        public MapInfoValidator()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;
            RuleFor(item => item.Address).NotEmpty().WithErrorCode("ShouldNotBeEmpty");
            RuleFor(item => item.test).NotEmpty().WithErrorCode("ShouldNotBeEmpty"); 
        }
    }
}
