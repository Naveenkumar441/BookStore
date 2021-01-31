using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //var obj = new { Id = 1, Name = "Naveen" };
            //return View(obj);
            //return View("AboutUS",obj);
            //return View("../../TempView/NaveenTemp"); --for external view
            //return View("TempView/NaveenTemp.cshtml");--for external view
            //return View("~/TempView/NaveenTemp.cshtml");--for external view
            //return View("AboutUS");
            //return "Hello from Home Controller index";
            return View();
        }
        public ViewResult ContactUs()
        {
            return View();
            //return "Hello from Home Controller Contact Us";
        }
        public ViewResult AboutUs()
        {
            return View();
        }
    }
}
