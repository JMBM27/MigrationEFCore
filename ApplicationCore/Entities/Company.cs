using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Entities;

public class Company : BaseEntity
{
    [Required, MinLength(5), MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required]
    public bool Active { get; set; }

}
