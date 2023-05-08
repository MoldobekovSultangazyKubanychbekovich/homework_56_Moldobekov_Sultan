using home_56.Models;
using Microsoft.AspNetCore.Mvc;

namespace home_56.Controllers
{
    public class BrandsController : Controller
    {
        private StoreContext _db;
        public BrandsController(StoreContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Brand> brands = _db.Brands.ToList();
            return View(brands);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Check()
        {
            List<Brand> brands = _db.Brands.ToList();
            return View(brands);
        }

        [HttpPost]
        public IActionResult Create(Brand brand)
        {
            if (brand != null)
            {
                if (_db.Brands.Any(b => b.Name == brand.Name) == true)
                {
                    return RedirectToAction("Check");
                }
                else
                {
                    _db.Brands.Add(brand);
                    _db.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int brandId)
        {
            Brand brand = _db.Brands.FirstOrDefault(p => p.Id == brandId);
            _db.Brands.Remove(brand);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Update(int brandId)
        {
            if (brandId != null)
            {
                Brand brand = _db.Brands.FirstOrDefault(b => b.Id == brandId);
                if (brand != null)
                {
                    return View(brand);
                }
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult Update(Brand brand)
        {
            if (brand != null)
            {
                _db.Brands.Update(brand);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
