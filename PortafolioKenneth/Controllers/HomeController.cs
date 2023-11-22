using Microsoft.AspNetCore.Mvc;
using PortafolioKenneth.Models;
using System.Diagnostics;

namespace PortafolioKenneth.Controllers
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
            //Persona p = new Persona();
            //p.Edad = DateTime.Now.Year-1991;
            //p.Nombre = "Kenneth Gaitán";
            var proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
        }

        public IActionResult Privacy()
        {
            return View();
        }


        private List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>(){ new Proyecto
            {
                Titulo="People Thrust",
                Descripcion="Outsourcing de desarrollo en .NET CORE",
                Link="https://peoplethrust.com",
                ImagenURL="/imagenes/amajpg.jpeg"
            },
            new Proyecto
            {
                Titulo="Dominion",
                Descripcion="Outsourcing de desarrollo en .NET MVC",
                Link="https://dominion.com",
                ImagenURL="/imagenes/amajpg.jpeg"
            },
            new Proyecto
            {
                Titulo="Juega OK",
                Descripcion="Recursos humanos",
                Link="https://juegaok.com",
                ImagenURL="/imagenes/amajpg.jpeg"
            },
            };
            }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}