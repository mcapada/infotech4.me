using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using It4MEProject.Models;

namespace It4MEProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Returns the Index.cshtml page from the Views/Home Folder
        public IActionResult Index()
        {
            return View();
        }

        // Returns the Privacy.cshtml page from the Views/Home Folder
        public IActionResult Privacy()
        {
            return View();
        }

        // Code is not used in the solution
        public IActionResult Demo()
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
