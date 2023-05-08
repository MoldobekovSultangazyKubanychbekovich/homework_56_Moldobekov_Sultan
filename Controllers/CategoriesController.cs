using home_56.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace home_56.Controllers
{
    [Authorize(Roles = "admin")]
    public class CategoriesController : Controller
    {
        private StoreContext _db;
        public CategoriesController(StoreContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> category = _db.Categories.ToList();
            return View(category);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Check()
        {
            List<Category> categories = _db.Categories.ToList();
            return View(categories);
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (category != null)
            {
                if (_db.Categories.Any(c => c.Name == category.Name) == true)
                {
                    return RedirectToAction("Check");
                }
                else
                {
                    _db.Categories.Add(category);
                    _db.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int categoryId)
        {
             Category category = _db.Categories.FirstOrDefault(p => p.Id == categoryId);
            _db.Categories.Remove(category);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Update(int categoryId)
        {
            if (categoryId != null)
            {
                Category category = _db.Categories.FirstOrDefault(c => c.Id == categoryId);
                if (category != null)
                {
                    return View(category);
                }
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult Update(Category category)
        {
            if (category != null)
            {
                _db.Categories.Update(category);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
