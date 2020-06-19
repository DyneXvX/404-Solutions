using System;
using System.Diagnostics;
using System.Globalization;
using Group_Setup.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Group_Setup.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserModel user)
        {
            var value = user.Number;

            while (value != null)
            {
                var number = value.ToLower(); 
                if ((number == "n01047219") || (number == "01047219"))
                    return View("../Users/Camille");
                if ((number == "n00810925") || (number == "00810925"))
                    return View("../Users/Lital");
                if ((number == "n01425550") || (number == "01425550"))
                    return View("../Users/Mervens");
            }
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}