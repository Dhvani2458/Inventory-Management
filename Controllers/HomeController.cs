using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _360_InventoryApp.Models;


namespace _360_InventoryApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
