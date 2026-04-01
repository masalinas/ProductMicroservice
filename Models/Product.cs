using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProductMicroservice.Models;

[Table("product")]
public class Product
{
    [Key]
    [Column("product_id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; } = string.Empty;

    [Column("price")]
    public float Price { get; set; }

    [Column("brand_id")]
    public int BrandId { get; set; }

    [ForeignKey("BrandId")]
    public virtual Brand? Brand { get; set; }
}