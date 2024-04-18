using BookBazaar.Data;
using BookBazaar.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookBazaar.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var objCategoryList = _context.Categories.ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid) 
            { 
            _context.Categories.Add(category); 
            _context.SaveChanges();
            return RedirectToAction("Index");
            }
            return View();
        }
    }
}
