using CreditoDigital.Client;
using CreditoDigital.Model;
using CreditoDigital.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CreditoDigital.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICoreVedic _coreVedic;

        public HomeController(ILogger<HomeController> logger, ICoreVedic coreVedic)
        {
            _logger = logger;
            _coreVedic = coreVedic;
        }

        public async Task<IActionResult> Index()
        {
            var param = new PruebaModel
            {
                Id = 1,
                Name = "Name",
                Description = "Description",
            };

            var strin = await _coreVedic.Prueba(param);

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

        [HttpPost]
        public async Task<IActionResult> GetDatos()
        {
            var param = new PruebaModel
            {
                Id = 1,
                Name = "Name",
                Description = "Description",
            };

            var strin = await _coreVedic.Prueba(param);

            return Json(strin);
        }
    }
}