using FluentValidation;
using TestWork3.Data.Models;

namespace TestWork3.Data.Validators;

public class OrganizationValidator : AbstractValidator<Organization>
{
    public OrganizationValidator()
    {
        RuleFor(property => property.Name)
            .NotNull().NotEmpty().WithMessage("'Название' не может быть пустым")
            .MinimumLength(2).WithMessage("'Название' должно быть большее 1 символа");
    }
}