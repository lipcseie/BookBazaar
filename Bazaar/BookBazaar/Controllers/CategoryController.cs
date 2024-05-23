using Bazaar.DataAccess.Data;
using Bazaar.DataAccess.Repository.IRepository;
using Bazaar.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookBazaar.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepo;
        public CategoryController(ICategoryRepository context)
        {
            _categoryRepo = context;
        }
        public IActionResult Index()
        {
            var objCategoryList = _categoryRepo.GetAll().ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (category.Name == category.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "DisplayOrder cannot match the Name");
            }
            if (ModelState.IsValid) 
            {
                _categoryRepo.Add(category);
                _categoryRepo.Save();
            TempData["success"] = "CATEGORY CREATED SUCCESFULLY";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var category = _categoryRepo.Get(u => u.Id == id);

            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryRepo.Add(category);
                _categoryRepo.Save();
                TempData["success"] = "CATEGORY UPDATED SUCCESFULLY";

                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var category = _categoryRepo.Get(u => u.Id == id);

            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Category category = _categoryRepo.Get(u => u.Id == id);

            if (category == null)
            {
                return NotFound();
            }
            _categoryRepo.Remove(category);
            _categoryRepo.Save();
            TempData["success"] = "CATEGORY DELETED SUCCESFULLY";
            return RedirectToAction("Index");
        }
    }
}
