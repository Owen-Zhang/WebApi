using Owen.Site.Services.Common;
using ServiceStack.FluentValidation;

namespace Owen.Site.Services.Map
{
    public class ListMapInfoValidator : ValidatorBase<ListMapInfoServiceRequest>
    {
        public ListMapInfoValidator()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;
            RuleFor(item => item.Address).NotEmpty().WithErrorCode("ShouldNotBeEmpty");
            RuleFor(item => item.test).NotEmpty().WithErrorCode("ShouldNotBeEmpty"); 
        }
    }
}
