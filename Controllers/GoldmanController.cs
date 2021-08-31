using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Goldman.Controllers
{
    public class GoldmanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
