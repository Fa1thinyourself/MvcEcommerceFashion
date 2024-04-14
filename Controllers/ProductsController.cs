using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcEcommerceFashion.Data;

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

      return View(product);
    }
  }
}
