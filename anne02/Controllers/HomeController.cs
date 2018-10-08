using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using anne02.Models;

namespace anne02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Services()
        {
            ViewData["Message"] = "Your SERVICES page.";

            return View();
        }

        public IActionResult Work()
        {
            ViewData["Message"] = "Your WORK page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your CONTACT page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
