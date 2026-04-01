using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ProductMicroservice.Models;

[Table("brand")]
public class Brand
{
    [Key]
    [Column("brand_id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; } = string.Empty;

    [Column("address")]
    public string Address { get; set; } = string.Empty;

    [Column("phone")]
    public string Phone { get; set; } = string.Empty;

    [JsonIgnore]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}