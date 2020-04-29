using Finance.Core.DTOs;
using FluentValidation;

namespace Finance.Core.Validators
{
    public class CreateTransactionValidator : AbstractValidator<CreateTransactionDto>
    {
        public CreateTransactionValidator()
        {
            RuleFor(t => t.Name).NotEmpty();
            RuleFor(t => t.TranType).NotNull().IsInEnum();
            RuleFor(t => t.TranDate).NotNull();
            RuleFor(t => t.Amount).NotNull().GreaterThan(0);
            RuleFor(t => t.ContactId).NotNull();
            RuleFor(t => t.UserId).NotNull();
            RuleFor(t => t.IsRecurring).NotNull();
            RuleFor(t => t.Frequency).NotNull().When(t => t.IsRecurring);
        }
    }
}
