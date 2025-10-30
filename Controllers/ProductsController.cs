using Microsoft.AspNetCore.Mvc;
using _360_InventoryApp.Models;
using System.Linq;

namespace _360_InventoryApp.Controllers
{
    public class ProductsController : Controller
    {
        public static List<Product> products = new List<Product>();

        public IActionResult Index() => View(products);

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Product product)
        {
            product.Id = products.Count > 0 ? products.Max(x => x.Id) + 1 : 1;
            products.Add(product);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            return product == null ? NotFound() : View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            var p = products.FirstOrDefault(x => x.Id == product.Id);
            if (p != null)
            {
                p.SKU = product.SKU;
                p.Name = product.Name;
                p.Description = product.Description;
                p.Stock = product.Stock;
                p.Supplier = product.Supplier;
            }
            return RedirectToAction("Index");
        }
    }
}
