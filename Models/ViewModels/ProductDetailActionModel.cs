using MvcEcommerceFashion.Models.EntityModels;

namespace MvcEcommerceFashion.Models.ViewModels;
public class ProductsDetailActionModel
{
  public Product? Product { get; set; }
  public List<Product> RelatedProducts { get; set; } = new List<Product>();
}
