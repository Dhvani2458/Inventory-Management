using Microsoft.AspNetCore.Mvc;
using _360_InventoryApp.Models;
using System.Linq;

namespace _360_InventoryApp.Controllers
{
    public class OrdersController : Controller
    {
        static List<Order> orders = new List<Order>();
        static List<Product> products = ProductsController.products; // Access product list for stock/demo

        public IActionResult Index() => View(orders);

        public IActionResult Details(int id)
        {
            var order = orders.FirstOrDefault(x => x.Id == id);
            return order == null ? NotFound() : View(order);
        }

        public IActionResult Create()
        {
            ViewBag.Products = products;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Order order)
        {
            order.Id = orders.Count > 0 ? orders.Max(x => x.Id) + 1 : 1;
            order.OrderDate = DateTime.Now;
            order.Total = order.Items.Sum(x => x.UnitPrice * x.Quantity);
            orders.Add(order);
            return RedirectToAction("Index");
        }
    }
}
