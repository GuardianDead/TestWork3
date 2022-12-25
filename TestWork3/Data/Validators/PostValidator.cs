using FluentValidation;
using TestWork3.Data.Models;

namespace TestWork3.Data.Validators;

public class PostValidator: AbstractValidator<Post>
{
    public PostValidator()
    {
        RuleFor(property => property.Name)
            .NotNull().NotEmpty().WithMessage("'Название' не может быть пустым")
            .MinimumLength(3).WithMessage("'Название' должно быть большее 2 символов");
    }
}