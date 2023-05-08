using home_56.Models;
using home_56.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace home_56.Controllers
{
    public class ProductsController : Controller
    {
        private StoreContext _db;
        public ProductsController(StoreContext db)
        {
            _db = db;
        }
        public IActionResult Index(int page=1)
        {
            List<Product> products = _db.Products.ToList();
            int pageSize = 3;
            var count = products.Count();
            var items = products.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            PageViewModel pvm = new PageViewModel(count, page, pageSize);
            ProductPagingViewModel productPaging = new ProductPagingViewModel
            {
                PageViewModel = pvm,
                Products = items
            };
            return View(productPaging);
        }

        public IActionResult Details(int productId)
        {
            Product product = _db.Products.FirstOrDefault(p => p.Id == productId);
            ViewBag.Categories = _db.Categories.ToList();
            ViewBag.Brands = _db.Brands.ToList();
            return View(product);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = _db.Categories.ToList();
            ViewBag.Brands = _db.Brands.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            try
            {
                if (product != null)
                {
                    _db.Products.Add(product);
                    _db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Create");
            }
        }

        public IActionResult Update(int productId)
        {
            Product product = _db.Products.FirstOrDefault(p => p.Id == productId);
            ViewBag.Categories = _db.Categories.ToList();
            ViewBag.Brands = _db.Brands.ToList();
            return View(product);
        }
        public IActionResult Delete(int productId)
        {
            Product product = _db.Products.FirstOrDefault(p => p.Id == productId);
            _db.Products.Remove(product);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {

            if (product != null)
            {
                product.DateUpdate = DateTime.Now.ToString();
                _db.Products.Update(product);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
