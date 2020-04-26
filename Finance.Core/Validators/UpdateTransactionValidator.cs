using Finance.Core.DTOs;
using FluentValidation;

namespace Finance.Core.Validators
{
    public class UpdateTransactionValidator : AbstractValidator<UpdateTransactionDto>
    {
        public UpdateTransactionValidator()
        {
            RuleFor(t => t.TranId).NotNull();
            RuleFor(t => t.Name).NotEmpty();
            RuleFor(t => t.TranType).NotNull().IsInEnum();
            RuleFor(t => t.TranDate).NotNull();
            RuleFor(t => t.Amount).NotNull().GreaterThan(0);
            RuleFor(t => t.ContactId).NotNull();
            RuleFor(t => t.IsRecurring).NotNull();
            RuleFor(t => t.TranRecId).NotNull().When(t => t.IsRecurring);
            RuleFor(t => t.Frequency).NotNull().When(t => t.IsRecurring);
        }
    }
}
