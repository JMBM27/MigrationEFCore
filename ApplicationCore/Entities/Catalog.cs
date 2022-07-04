using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Entities;

public class Catalog : BaseEntity
{

    [Required, MinLength(5), MaxLength(20)]
    public string Code { get; set; } = string.Empty;

    [Required, MinLength(5), MaxLength(100)]
    public string Description { get; set; } = string.Empty;

    [Required, Precision(18,4) , Range(0, Double.PositiveInfinity)]
    public decimal Price { get; set; }

    [DefaultValue(0.0d), Precision(18, 4), Range(0, Double.PositiveInfinity)]
    public decimal Offer { get; set; }

    [Required, DefaultValue(1)]
    public byte OfferCalculation { get; set; }



    public User User { get; set; }

}
