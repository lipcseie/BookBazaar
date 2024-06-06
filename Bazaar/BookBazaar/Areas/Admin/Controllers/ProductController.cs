using Microsoft.AspNetCore.Mvc;

namespace BookBazaar.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
