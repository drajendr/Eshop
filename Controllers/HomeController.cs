using EShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;        

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;            
        }
       
        public IActionResult Index()
        {
            if (User.IsInRole("User"))
                return RedirectToAction("Index", "Home", new { area = "Customer" });
            if(User.IsInRole("Admin"))
                return RedirectToAction("Index", "Product", new { area = "Admin" });
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
