using System;
using Owen.Site.Core.Common;
using ServiceStack.FluentValidation;
using ServiceStack.FluentValidation.Results;

namespace Owen.Site.Services.Common
{
    public abstract class ValidatorBase<T> : AbstractValidator<T>
    {
        /// <summary>
        /// 可以加公共的RuleFor
        /// </summary>
        protected ValidatorBase()
        { 
            //this.RuleFor<string>(express).doValidator();
        }

        public override ValidationResult Validate(T instance)
        {
            var validateResult = base.Validate(instance);
            Validate(validateResult);
            return validateResult;
        }

        public override ValidationResult Validate(ValidationContext<T> context)
        {
            var validateResult = base.Validate(context);
            Validate(validateResult);
            return validateResult;
        }

        public virtual void Validate(ValidationResult result)
        { 
            if (!result.IsValid)
                throw new BussinessException(string.Join(Environment.NewLine, result.Errors));
        }
    }
}
