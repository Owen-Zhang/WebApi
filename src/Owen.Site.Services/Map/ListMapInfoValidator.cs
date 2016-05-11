using ServiceStack.FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owen.Site.Services.Map
{
    public class ListMapInfoValidator : AbstractValidator<ListMapInfoServiceRequest>
    {
        public ListMapInfoValidator()
        {
            RuleFor(item => item.Address).NotEmpty().WithMessage("please input Address info");
        }
    }
}
