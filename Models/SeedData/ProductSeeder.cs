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
        DetailDescription = "Introducing our Elegant Evening Jacket: Crafted with meticulous attention to detail, this timeless piece is designed to turn heads and break hearts. Whether you’re attending a gala, a romantic dinner, or a special event, this jacket exudes sophistication and elegance.",
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
        DetailDescription = "Are you ready to make a statement? Our Fashion Set Clothes collection brings you the perfect blend of comfort, style, and sophistication. Whether you’re stepping out for a coffee date, a casual hangout, or a night on the town, our two-piece sets have got you covered.",
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
        DetailDescription = "Crafted from high-quality linen, this versatile piece is a must-have for every fashion-forward individual. Experience the natural breathability and softness of pure linen. Our top is lightweight, making it ideal for warm days and transitional seasons. The relaxed fit ensures all-day comfort. Whether you’re running errands, attending meetings, or enjoying a leisurely brunch, you’ll feel at ease.",
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
        DetailDescription = "Timeless elegance meets playful chic in our Dotted Black Dress. Crafted from high-quality linen, this versatile piece transitions effortlessly from day to night. The black-on-black polka dot pattern adds whimsy, while the tailored silhouette flatters your curves. Whether you’re attending a cocktail party or a weekend brunch, this dress exudes confidence. Pair it with heels for a night out or ankle boots for daytime chic. Shop now and embrace the allure of polka dots! ",
        ImageUrl = "/images/product/image3.png",
        IsOutOfStock = false,
        Price = 25,
        Stock = 1000,
        UpdatedAt = DateTime.Now,
      }, new Product
      {
        Name = "Boxy Denim Hat",
        Tag = "Discounted Price",
        Description = "Crafted for the fashion-forward, our Boxy Denim Hat seamlessly blends street style with sophistication.",
        DetailDescription = "Crafted for the fashion-forward, our Boxy Denim Hat seamlessly blends street style with sophistication. The structured silhouette and sturdy denim fabric make it a versatile accessory for any season. Whether you’re strolling through the city or attending a music festival, this hat adds an edgy flair. Pair it with oversized sunglasses and a leather jacket for that effortlessly cool vibe. Shop now and embrace the urban chic! ",
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
        DetailDescription = "Timeless elegance meets versatility in our White Dress. Crafted from high-quality fabric, this wardrobe essential transitions effortlessly from day to night. The sleeveless, crew-neck design is perfect for showcasing sun-kissed skin, while the side slit adds a touch of sexiness. Whether you’re attending a garden party or a beach wedding, this dress exudes confidence. Pair it with strappy sandals for a breezy daytime look or heels for an elegant evening affair. Shop now and embrace the allure of simplicity! ",
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
        DetailDescription = "Crafted for comfort and style, our Full Sweater is a must-have for chilly days. Whether you’re sipping cocoa by the fireplace or strolling through autumn leaves, this cozy piece has you covered. Made from a blend of wool and cashmere, it wraps you in warmth without compromising on softness. The ribbed cuffs and hem ensure a snug fit. Versatile styling options allow you to pair it with jeans for a casual weekend look or layer it over a collared shirt for a smart-casual ensemble. To maintain its quality, hand wash in cold water and lay flat to dry. Shop now and embrace the comfort of our Full Sweater! ",
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
        DetailDescription = "Crafted for comfort and style, our Long Sleeve Coat is a must-have for chilly days. Whether you’re sipping cocoa by the fireplace or strolling through autumn leaves, this cozy piece has you covered. Made from a blend of wool and cashmere, it wraps you in warmth without compromising on softness. The tailored silhouette ensures a flattering fit, while the button-down front adds a touch of sophistication. Versatile styling options allow you to layer it over dresses for a polished office look or pair it with jeans for a chic weekend ensemble. To maintain its quality, dry clean only. Shop now and embrace the elegance of our Long Sleeve Coat! ",
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
