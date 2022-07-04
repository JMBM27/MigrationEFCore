using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities;

public class BaseEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [DataType(DataType.DateTime), 
     DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "yyyy-MM-dd HH:mm:ss.ssss")]
    public DateTime CreatedAt { get; set; }
}
