using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcEcommerceFashion.Data;
using MvcEcommerceFashion.Models.EntityModels;
using MvcEcommerceFashion.Models.ViewModels;

namespace MvcEcommerceFashion.Controllers
{
  public class ProductsController : Controller
  {
    private readonly EntityDbContext _context;
    public ProductsController(EntityDbContext context)
    {
      _context = context;
    }

    // GET: Products
    public async Task<IActionResult> Index()
    {
      return View(await _context.Product.ToListAsync());
    }

    // GET: Products/Details/5
    public async Task<IActionResult> Details(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var product = await _context.Product.FirstOrDefaultAsync(m => m.Id == id);
      if (product == null)
      {
        return NotFound();
      }

      var rnd = new Random();
      const int CountItemToGet = 3;

      var relatedProducts = await _context.Product
        .Where(p => p.Id != id)
        .ToListAsync();
      var hashSetProductsRandom = new HashSet<Product>();

      while (hashSetProductsRandom.Count < CountItemToGet)
      {
        var productRandom = relatedProducts[rnd.Next(relatedProducts.Count)];
        hashSetProductsRandom.Add(productRandom);
      }

      var productDetailActionModel = new ProductsDetailActionModel{
        Product = product,
        RelatedProducts = [.. hashSetProductsRandom]
      };
      return View(productDetailActionModel);
    }
  }
}
