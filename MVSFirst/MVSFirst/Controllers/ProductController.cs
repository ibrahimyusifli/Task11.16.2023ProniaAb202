using Microsoft.AspNetCore.Mvc;

namespace MVSFirst.Controllers
{
    public class ProductController:Controller
    {
        public IActionResult Index()
        {
            // return View();

            return RedirectToAction("Index","Home");
        }

        public IActionResult Detail()
        {
            return View("Product");
        }
    }
}
