using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Group_Setup.Controllers
{
    public class User : Controller
    {


        public IActionResult Camille()
        {
            return View("../Users/Camille");
        }

        public IActionResult Lital()
        {
            return View("../Users/Lital");
        }

        public IActionResult Mervens()
        {
            return View("../Users/Mervens");
        }
    }
}
