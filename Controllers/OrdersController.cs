using home_56.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Numerics;

namespace home_56.Controllers
{
    public class OrdersController : Controller
    {
        private StoreContext _db;
        public OrdersController(StoreContext db)
        {
            _db = db;
        }
        [Authorize(Roles = "admin, user")]

        public IActionResult Index()
        {
            List<Order> orders = _db.Orders.ToList();
            return View(orders);
        }
        [Authorize(Roles = "user")]
        public IActionResult Create(int productId)
        {
            Product product = _db.Products.FirstOrDefault(p => p.Id == productId);
            return View(new Order { Product = product });
        }
        [Authorize(Roles = "user")]
        [HttpPost]
        public IActionResult Create(Order order)
        {
            if (order != null)
            {
                _db.Orders.Add(order);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
