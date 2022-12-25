using FluentValidation;
using TestWork3.Data.Models;

namespace TestWork3.Data.Validators;

public class EmployeeValidator : AbstractValidator<Employee>
{
    public EmployeeValidator()
    {
        RuleFor(property => property.FirstName)
            .NotNull().NotEmpty().WithMessage("'Имя' не может быть пустым")
            .MinimumLength(2).WithMessage("'Имя' должно быть больше 1 символа");
        RuleFor(property => property.SecondName)
            .NotNull().NotEmpty().WithMessage("'Фамилия' не может быть пустым")
            .MinimumLength(2).WithMessage("'Фамилия' должна быть больше 1 символа");
        RuleFor(property => property.LastName)
            .MinimumLength(2).WithMessage("'Отчество' должно быть больше 1 символа");
        RuleFor(property => property.Email)
            .NotNull().NotEmpty().WithMessage("'Почта' не может быть пустой")
            .EmailAddress().WithMessage("'Почта' введена некорректно");
        RuleFor(property => property.Phone)
            .NotNull().NotEmpty().WithMessage("'Телефон' не может быть пустым")
            .Matches(@"\+?\d{1,4}?[-.\s]?\(?\d{1,3}?\)?[-.\s]?\d{1,4}[-.\s]?\d{1,4}[-.\s]?\d{1,9}")
            .WithMessage("'Телефон' введен некорректно");
        RuleFor(property => property.Gender)
            .IsInEnum().WithMessage("'Пол' не может другого вида");
    }
}