using Microsoft.AspNetCore.Mvc;
using sociCalendario.Website.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace sociCalendario.Website.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetOpen()
        {
            Random rand = new Random();
            bool randomBool = rand.NextDouble() >= 0.5;

            return Json(randomBool);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
