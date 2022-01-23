using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestaurantSIGLO21.Models;

namespace RestaurantSIGLO21.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Informacion del Restaurant";

            return View();
        }

        public IActionResult Menu()
        {
            ViewData["Message"] = "Menu Page";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            ViewData["Message"] = "Your Login page";

            return View();
        }

        public IActionResult Platos()
        {
            ViewData["Message"] = "Platos mas conocidos";

            return View();
        }

        public IActionResult Team()
        {
            ViewData["Message"] = "Miembros del Equipo";

            return View();
        }

        public IActionResult Reservation()
        {
            ViewData["Message"] = "Paginas de Reserva";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
