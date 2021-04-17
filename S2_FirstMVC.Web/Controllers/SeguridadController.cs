using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2_FirstMVC.Web.Controllers
{
    public class SeguridadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {

            if (email == "luis@esan.edu.pe" && password == "123456")
            {
                return RedirectToAction("Index", "Home", new { area = "Marketing" });
            }

            return View();
        }

    }
}
