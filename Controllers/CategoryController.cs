using BulkeyWeb.Data;
using BulkeyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkeyWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            List<Category> category = _context.Categories.ToList();
            return View(category);
        }
    }
}
