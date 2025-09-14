using FluentValidation;
using CashFlow.Exception;
using CashFlow.Communication.Requests;
namespace CashFlow.Application.UseCases.Users.Update
{
    public class UpdateUserValidator : AbstractValidator<RequestUpdateUserJson>
    {

        public UpdateUserValidator()
        {
            RuleFor(user => user.Name).NotEmpty().WithMessage(ResourceErrorMessages.NAME_REQUIRED);
            RuleFor(user => user.Email)
                .NotEmpty()
                .WithMessage(ResourceErrorMessages.EMAIL_REQUIRED)
                .EmailAddress()
                .When(user => string.IsNullOrWhiteSpace(user.Email) == false, ApplyConditionTo.CurrentValidator)
                .WithMessage(ResourceErrorMessages.EMAIL_INVALID);
        }
    }
}
