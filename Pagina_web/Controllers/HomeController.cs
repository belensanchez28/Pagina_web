using Microsoft.AspNetCore.Mvc;
using Pagina_web.Models;
using System.Diagnostics;

namespace Pagina_web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cartas()
        {
            return View();
        }
        public IActionResult canciones()
        {
            return View();
        }

        public IActionResult Peliculas()
        {
            return View();
        }
        public IActionResult Cita()
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
