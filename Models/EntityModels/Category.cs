using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MvcEcommerceFashion.Models.EntityModels;

public class Category : BaseModel
{
  [Required]
  [Column(TypeName = "nvarchar(128)")]
  public string? Name { get; set; }

  [Column(TypeName = "nvarchar(256)")]
  public string? Description { get; set; }
}
