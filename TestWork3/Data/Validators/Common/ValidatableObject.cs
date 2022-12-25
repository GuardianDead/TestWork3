using System.ComponentModel.DataAnnotations;
using FluentValidation;

namespace TestWork3.Data.Validators.Common;

public class ValidatableObject<T> : IValidatableObject where T : class
{
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var validator = validationContext.GetRequiredService<IValidator<T>>();
        var result = validator.Validate((T)validationContext.ObjectInstance);
        return result.Errors.Select(error => new ValidationResult(error.ErrorMessage, new []{error.PropertyName}));
    }
}