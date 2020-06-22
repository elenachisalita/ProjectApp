using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjectApp.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
          
            return View();
        }

        [HttpGet("contact")]

        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Us";
            throw new InvalidOperationException("Bad things happen");

            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";
            return View();
        }
    }
}