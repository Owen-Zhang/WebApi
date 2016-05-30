using ServiceStack.FluentValidation;

namespace Owen.Site.Services.Map
{
    public class ListMapInfoValidator : AbstractValidator<ListMapInfoServiceRequest>
    {
        public ListMapInfoValidator()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;
            RuleFor(item => item.Address).NotEmpty().WithErrorCode("ShouldNotBeEmpty");
            RuleFor(item => item.test).NotEmpty().WithErrorCode("ShouldNotBeEmpty"); 
        }
    }
}
