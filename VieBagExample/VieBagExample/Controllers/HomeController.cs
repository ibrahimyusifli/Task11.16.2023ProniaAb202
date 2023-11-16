using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VieBagExample.Models;

namespace VieBagExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { Id = 1, Name = "Fidan", Surname = "Behbudova", Age = 20 });
            students.Add(new Student { Id = 2, Name = "Nubar", Surname = "Abudova", Age = 19 });
            students.Add(new Student { Id = 3, Name = "Elburus", Surname = "Mirzayev", Age = 19 });
            students.Add(new Student { Id = 3, Name = "Amin", Surname = "Pashayev", Age = 19 });

            // ViewBag.Students = students;  //view icine data gonderir

            //  ViewData["Students"]=students;   //Students key altinda listin deyerlerini saxlayir

            //TempData["Name"] = "Azer";  //Action lar arasinda gondere bilirik ve 1 defe istifade ede bilirik


            return View(students);
        }

        public IActionResult About()
        {
            string name = TempData["Name"].ToString();
            Console.WriteLine(name);

            return View();
        }
    }
}
