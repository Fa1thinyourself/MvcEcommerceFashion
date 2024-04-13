using System.ComponentModel.DataAnnotations.Schema;

namespace MvcEcommerceFashion.Models.EntityModels;
public class BaseModel
{
  [Column(Order = 0)]
  public int Id { get; set; }

  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  [Column(Order = 998)]
  public DateTime CreatedAt { get; set; }

  [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
  [Column(Order = 999)]
  public DateTime UpdatedAt { get; set; }
}
