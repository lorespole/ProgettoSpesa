using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProgettoSpesa.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProgettoSpesa.Controllers
{
    public class SpesaController : Controller
    {
        private readonly ILogger<SpesaController> _logger;

        public SpesaController(ILogger<SpesaController> logger)
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
