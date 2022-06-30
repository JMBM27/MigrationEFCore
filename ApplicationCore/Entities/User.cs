using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Entities;

[Index(nameof(Email), IsUnique = true)]
public class User : BaseEntity
{

    [Required, DataType(DataType.EmailAddress)]
    public string Email { get; set; } = string.Empty;

    [Required, JsonIgnore]
    public string Password { get; set; } = string.Empty;

    public Company? Company { get; set; }

}
