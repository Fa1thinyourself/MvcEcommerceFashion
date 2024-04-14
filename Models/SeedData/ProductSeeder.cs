using Microsoft.EntityFrameworkCore;
using MvcEcommerceFashion.Data;
using MvcEcommerceFashion.Models.EntityModels;

namespace MvcEcommerceFashion.Models.SeedData;

public class ProductSeeder
{
  public static void Initialize(IServiceProvider serviceProvider)
  {
    using (var context = new EntityDbContext(
      serviceProvider.GetRequiredService<DbContextOptions<EntityDbContext>>()
    ))
    {
      // Look for any products.
      if (context.Product.Any())
      {
        return;   // DB has been seeded
      }
      context.Product.AddRange(new Product{
        Name = "Product 1",
        Description = "Product 1 Description",
        ImageUrl = "Product 1 ImageUrl",
        IsOutOfStock = false,
        Price = 100,
        Stock = 10
      });
    }
  }
}
