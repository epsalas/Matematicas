using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Matematicas.Models;

namespace Matematicas.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult FMixto(){
            return View();
        }

        [HttpPost]
        public IActionResult FMixto(FMixto fMixto){
            if (ModelState.IsValid)
            {
                fMixto.entero = fMixto.numerador/fMixto.denominador;
                fMixto.suma = fMixto.numerador - (fMixto.entero * fMixto.denominador);
                
                if(fMixto.suma == 0){
                    fMixto.Mensaje = "El resultado es un numero entero: "+fMixto.entero;
                }else{
                    fMixto.Mensaje = "El resultado es un numero mixto: "+fMixto.entero+ "  "+ fMixto.suma+"/" + fMixto.denominador;
                }

                
            }

            return View("FMixto", fMixto);
        }
    }
}
