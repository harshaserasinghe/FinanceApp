using Finance.Core.DTOs;
using FluentValidation;

namespace Finance.Core.Validators
{
    public class UpdateContactValidator : AbstractValidator<UpdateContactDto>
    {
        public UpdateContactValidator()
        {
            RuleFor(c => c.ContactId).NotNull();
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.BusinessType).NotEmpty();
            RuleFor(c => c.Address).NotEmpty();
            RuleFor(c => c.PhoneNumber).NotEmpty();
        }
    }
}
