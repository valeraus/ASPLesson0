﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task02.Models;

namespace Task02.Controllers
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
        public IActionResult Page2()
        {
            return View();
        }

        public IActionResult Menu1()
        {
            return View();
        }

        public IActionResult Menu2()
        {
            return View();
        }

        public IActionResult Menu3()
        {
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