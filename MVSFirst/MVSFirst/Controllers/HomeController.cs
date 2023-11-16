using Microsoft.AspNetCore.Mvc;

namespace MVSFirst.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()    //Action
        {

            return View();
            //JsonResult json = new JsonResult(new
            //{
            //    name = "ibrahim",
            //    surname = "yusifli",
            //    age = 19
            //});

            //if (true)
            //{
            //return View();
            //}

            //return json;
        }

        public IActionResult details(int id)
        {
            return View("Product");
        }
    }
}
