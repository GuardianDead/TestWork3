using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using FluentValidation;
using TestWork3.Data.Validators.Common;

namespace TestWork3.Data.Models;

public class Organization : ValidatableObject<Organization>
{
    [Key]
    [DisplayName("Название")]
    public string Name { get; set; }

    public override string ToString() => Name;
}