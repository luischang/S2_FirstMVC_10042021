using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using S2_FirstMVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace S2_FirstMVC.Web.Controllers
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

        public IActionResult Services()
        {
            var servicios = new List<Servicio>();
            Servicio serv1 = new Servicio(1, "Cocinar");
            Servicio serv2 = new Servicio(2, "Lavar");
            Servicio serv3 = new Servicio(3, "Planchar");

            servicios.Add(serv1);
            servicios.Add(serv2);
            servicios.Add(serv3);

            ViewBag.ListadoServicio = servicios;
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
