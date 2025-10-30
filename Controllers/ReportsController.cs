using Microsoft.AspNetCore.Mvc;
using _360_InventoryApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace _360_InventoryApp.Controllers
{
    public class ReportsController : Controller
    {
        static List<Product> products = ProductsController.products;

        public IActionResult LowStock()
        {
            var lowStock = products.Where(x => x.Stock < 10).ToList();
            return View(lowStock);
        }
    }
}
