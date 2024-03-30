using Microsoft.AspNetCore.Mvc;
using Proyecto.Models;
using System.Diagnostics;

namespace Proyecto.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult PantallaInicio()
        {
            return View();
        }

        public IActionResult IniciarSesion()
        {
            return View();
        }

        public IActionResult RegistrarUsuario()
        {
            return View();
        }
    }
}