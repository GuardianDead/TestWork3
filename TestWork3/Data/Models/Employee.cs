using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json.Serialization;
using TestWork3.Data.Validators.Common;
using TestWork3.Domain.Types;

namespace TestWork3.Data.Models;

public class Employee : ValidatableObject<Employee>
{
    [Key]
    [DisplayName("Индификатор")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    [DisplayName("Имя")]
    public string FirstName { get; set; }
    [DisplayName("Фамилия")]
    public string SecondName { get; set; }
    [DisplayName("Отчество")]
    public string? LastName { get; set; }
    [DisplayName("Почта")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }
    [DisplayName("Телефон")]
    [DataType(DataType.PhoneNumber)]
    public string Phone { get; set; }
    [DisplayName("Пол")]
    [EnumDataType(typeof(GenderType))]
    public GenderType Gender { get; set; }

    [DisplayName("Должность")]
    [Display(AutoGenerateField = false)]
    public string PostName { get; set; }
    [ForeignKey("PostName")]
    public Post Post { get; set; }
    [DisplayName("Подразделение")]
    [Display(AutoGenerateField = false)]
    public string DivisionName { get; set; }
    [ForeignKey("DivisionName")]
    public Division Division { get; set; }
    [DisplayName("Организация")]
    [Display(AutoGenerateField = false)]
    public string OrganizationName { get; set; }
    [ForeignKey("OrganizationName")]
    public Organization Organization { get; set; }

    public override string ToString() => $@"{FirstName} {SecondName}";
}