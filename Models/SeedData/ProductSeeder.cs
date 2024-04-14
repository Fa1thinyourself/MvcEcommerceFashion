using Microsoft.EntityFrameworkCore;
using MvcEcommerceFashion.Data;
using MvcEcommerceFashion.Models.EntityModels;
using NuGet.Protocol;

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
      context.Product.AddRange(new Product
      {
        Name = "Elegant Jacket",
        Tag = "New Arrival",
        Description = "Original package design from SYMPHONIA",
        ImageUrl = "/images/product/image8.jpeg",
        IsOutOfStock = false,
        Price = 25,
        Stock = 1000,
        UpdatedAt = DateTime.Now,
      }, new Product
      {
        Name = "Fashion Set",
        Tag = "Low Price",
        Description = "Costume Package",
        ImageUrl = "/images/product/image3.jpeg",
        IsOutOfStock = false,
        Price = 35,
        Stock = 1500,
        UpdatedAt = DateTime.Now,
      }, new Product
      {
        Name = "Linen Plain Top",
        Tag = "",
        Description = "Nature Beauty from another world",
        ImageUrl = "/images/product/image10.png",
        IsOutOfStock = false,
        Price = 45,
        Stock = 1000,
        UpdatedAt = DateTime.Now,
      }, new Product
      {
        Name = "Dotted Black Dress",
        Tag = "New Arrival",
        Description = "Original package design from our love",
        ImageUrl = "/images/product/image3.png",
        IsOutOfStock = false,
        Price = 25,
        Stock = 1000,
        UpdatedAt = DateTime.Now,
      }, new Product
      {
        Name = "Boxy Denim Hat",
        Tag = "Discounted Price",
        Description = "Boxy Denim Hat",
        ImageUrl = "/images/product/image6.png",
        IsOutOfStock = false,
        Price = 35,
        Stock = 1000,
        UpdatedAt = DateTime.Now,
      }, new Product
      {
        Name = "White Dress",
        Tag = "",
        Description = "Nature Crafted made by the famous AL Karam",
        ImageUrl = "/images/product/images4.jpeg",
        IsOutOfStock = false,
        Price = 45,
        Stock = 1000,
        UpdatedAt = DateTime.Now,
      }, new Product
      {
        Name = "Full Sweater",
        Tag = "Trending",
        Description = "Original package design from SYMPHONIA",
        ImageUrl = "/images/product/images5.jpeg",
        IsOutOfStock = false,
        Price = 50,
        Stock = 1000,
        UpdatedAt = DateTime.Now,
      }, new Product
      {
        Name = "Long sleeve Coat",
        Tag = "",
        Description = "Package design",
        ImageUrl = "/images/product/jpg.png",
        IsOutOfStock = false,
        Price = 100,
        Stock = 1000,
        UpdatedAt = DateTime.Now,
      }, new Product
      {
        Name = "Rockstar Jacket",
        Tag = "",
        Description = "Original design from SYMPHONIA",
        ImageUrl = "/images/product/jpg1.png",
        IsOutOfStock = false,
        Price = 200,
        Stock = 1000,
        UpdatedAt = DateTime.Now,
      });
      context.SaveChanges();
    }
  }
}
