using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace sociCalendario.Website.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        IConfiguration siteConfig;

        public HomeController(IConfiguration configuration)
        {
            siteConfig = configuration;
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Search(string planet, string start_date, string end_date)
        {
            try
            {
                var culture = new System.Globalization.CultureInfo("es-ES");

                return PartialView("_SearchResults");
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
