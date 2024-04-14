using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcEcommerceFashion.Models.EntityModels;

public class Product : BaseModel
{
  [Required]
  [Column(TypeName = "nvarchar(128)")]
  public string? Name { get; set; }
  [Column(TypeName = "nvarchar(256)")]
  public string? ImageUrl { get; set; }
  [Column(TypeName = "nvarchar(256)")]
  public string? Description { get; set; }
  [Column(TypeName = "nvarchar(256)")]
  public string? Tag { get; set; }
  [Required]
  public float Price { get; set; } = 0;
  [Required]
  public int Stock { get; set; } = 0;
  [Required]
  [Column(TypeName = "bit")]
  public bool IsOutOfStock { get; set; } = false;
}
