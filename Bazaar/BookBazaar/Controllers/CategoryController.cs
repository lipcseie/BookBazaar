using Microsoft.AspNetCore.Mvc;

namespace BookBazaar.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
