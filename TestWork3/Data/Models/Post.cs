using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TestWork3.Data.Validators.Common;

namespace TestWork3.Data.Models;

public class Post : ValidatableObject<Post>
{
    [Key]
    [DisplayName("Название")]
    public string Name { get; set; }

    public override string ToString() => Name;
}