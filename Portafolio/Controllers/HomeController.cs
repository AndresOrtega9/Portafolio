using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Services;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepositorioProyectos _repositorioProyectos;

        public HomeController(IRepositorioProyectos repositorioProyectos)
        {
            _repositorioProyectos = repositorioProyectos;
        }
        public IActionResult Index()
        {
            var listado = _repositorioProyectos.ObtenerListaDeProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel { Proyectos = listado };
            return View(modelo);
        }

        public IActionResult Contacto()
        {
            return View();
        }

        public IActionResult Proyectos()
        {
            var proyectos = _repositorioProyectos.ObtenerListaDeProyectos().ToList();
            return View(proyectos);
        }

    }
}