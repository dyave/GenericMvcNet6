using GenericMvcNet6.Context;
using GenericMvcNet6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GenericMvcNet6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AdventureWorksLT2019Context _ctx;

        public HomeController(ILogger<HomeController> logger, AdventureWorksLT2019Context ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            var lista = _ctx.Products.ToList();
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