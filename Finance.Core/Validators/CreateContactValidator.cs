using Finance.Core.DTOs;
using FluentValidation;

namespace Finance.Core.Validators
{
    public class CreateContactValidator : AbstractValidator<CreateContactDto>
    {
        public CreateContactValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.BusinessType).NotEmpty();
            RuleFor(c => c.Address).NotEmpty();
            RuleFor(c => c.PhoneNumber).NotEmpty();
        }
    }
}
