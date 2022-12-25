using FluentValidation;
using TestWork3.Data.Models;

namespace TestWork3.Data.Validators;

public class DivisionValidator: AbstractValidator<Division>
{
    public DivisionValidator()
    {
        RuleFor(property => property.Name)
            .NotNull().NotEmpty().WithMessage("'Название' не может быть пустым");
    }
}