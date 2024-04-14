using System.ComponentModel.DataAnnotations.Schema;

namespace MvcEcommerceFashion.Models.EntityModels;
public class BaseModel
{
  [Column(Order = 0)]
  public int Id { get; set; }

  [Column(Order = 997)]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public DateTime? CreatedAt { get; set; } = DateTime.Now;

  [Column(Order = 998)]
  [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
  public DateTime? UpdatedAt { get; set; }
}
