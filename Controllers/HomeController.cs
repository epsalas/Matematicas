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
                }else if(fMixto.entero == 0){
                    fMixto.Mensaje = "El resultado es una fraccion: "+ fMixto.suma+"/" + fMixto.denominador;
                }else{
                    fMixto.Mensaje = "El resultado es un numero mixto: "+fMixto.entero+ "  "+ fMixto.suma+"/" + fMixto.denominador;
                }

                
            }

            return View("FMixto", fMixto);
        }

        public IActionResult FMixtoM(){
            return View();
        }

        [HttpPost]
        public IActionResult FMixtoM(FMixto fMixto){
            if (ModelState.IsValid)
            {   
                
                
                if(fMixto.denominador2==0  || fMixto.denominador==0){
                    fMixto.Mensaje = "Error al multiplicar, el denominador no puede ser 0";
                    
                    
                
                }else{
                    fMixto.numresu = fMixto.numerador*fMixto.numerador2;
                    fMixto.denresu = fMixto.denominador *fMixto.denominador2;
                    fMixto.entero = fMixto.numresu/fMixto.denresu;
                    fMixto.suma= fMixto.numresu -(fMixto.denresu*fMixto.entero);
                    
                    

                    if(fMixto.numresu >= fMixto.denresu){
                        
                        
                        
                        if(fMixto.suma == 0 || fMixto.numresu == fMixto.denresu){
                            fMixto.Mensaje = "El resultado es un numero entero: "+fMixto.entero;
                        }else {
                            fMixto.Mensaje = "El resultado es un numero mixto: "+fMixto.entero + "  "+fMixto.suma+ "/"+fMixto.denresu;
                            
                        }
                    }else {
                        fMixto.Mensaje = "El resultado es una fraccion: "+fMixto.numresu+"/" + fMixto.denresu;
                    }
                }
                
                
                

                
            }

            return View("FMixtoM", fMixto);
        }

        public IActionResult FSuma(){
            return View();
        }

        [HttpPost]
        public IActionResult FSuma(FMixto fMixto){
            if (ModelState.IsValid)
            {
                
                if(fMixto.denominador2==0  || fMixto.denominador==0){
                    fMixto.Mensaje = "Error al sumar, el denominador no puede ser 0";
                }else{
                    fMixto.denresu=fMixto.denominador*fMixto.denominador2;
                    fMixto.a= fMixto.numerador * (fMixto.denresu/fMixto.denominador);
                    fMixto.b= fMixto.numerador2 * (fMixto.denresu/fMixto.denominador2);
                    fMixto.c= fMixto.a + fMixto.b;

                    if(fMixto.c >= fMixto.denresu ){
                        fMixto.entero= fMixto.c/fMixto.denresu;
                        fMixto.suma = fMixto.c - (fMixto.entero*fMixto.denresu);
                        if(fMixto.suma == 0){
                            fMixto.Mensaje="El numero es un entero: "+fMixto.entero;
                        }else {

                            fMixto.Mensaje="El numero es un numero mixto: "+fMixto.entero+"  "+fMixto.suma+"/"+fMixto.denresu;
                        }
                        
                    }
                        
                    else{
                        fMixto.Mensaje="El numero es una fraccion: "+fMixto.c+"/"+fMixto.denresu;
                    }
                }


                
                
            }

            return View("FSuma", fMixto);
        }
        public IActionResult FResta(){
            return View();
        }

        [HttpPost]
        public IActionResult FResta(FMixto fMixto){
            if (ModelState.IsValid)
            {
                
                if(fMixto.denominador2==0  || fMixto.denominador==0){
                    fMixto.Mensaje = "Error al restar, el denominador no puede ser 0";
                }else{
                    fMixto.denresu=fMixto.denominador*fMixto.denominador2;
                    fMixto.a= fMixto.numerador * (fMixto.denresu/fMixto.denominador);
                    fMixto.b= fMixto.numerador2 * (fMixto.denresu/fMixto.denominador2);
                    fMixto.c= fMixto.a - fMixto.b;

                    if(fMixto.c >= fMixto.denresu ){
                        fMixto.entero= fMixto.c/fMixto.denresu;
                        fMixto.suma = fMixto.c - (fMixto.entero*fMixto.denresu);
                        if(fMixto.suma == 0){
                            fMixto.Mensaje="El numero es un entero: "+fMixto.entero;
                        }else {
                            
                            fMixto.Mensaje="El numero es un numero mixto: "+fMixto.entero+"  "+fMixto.suma+"/"+fMixto.denresu;
                        }
                        
                    }
                        
                    else{
                        fMixto.Mensaje="El numero es una fraccion: "+fMixto.c+"/"+fMixto.denresu;
                    }
                }


                
                
            }

            return View("FResta", fMixto);
        }

        public IActionResult FDivision(){
            return View();
        }

        [HttpPost]
        public IActionResult FDivision(FMixto fMixto){
            if (ModelState.IsValid)
            {   
                
                
                if(fMixto.denominador2==0  || fMixto.denominador==0){
                    fMixto.Mensaje = "Error al dividir, el denominador no puede ser 0";
                    
                    
                
                }else{
                    fMixto.numresu = fMixto.numerador*fMixto.denominador2;
                    fMixto.denresu = fMixto.numerador2 *fMixto.denominador;
                    fMixto.entero = fMixto.numresu/fMixto.denresu;
                    fMixto.suma= fMixto.numresu -(fMixto.denresu*fMixto.entero);
                    
                    

                    if(fMixto.numresu >= fMixto.denresu){
                        
                        
                        
                        if(fMixto.suma == 0 || fMixto.numresu == fMixto.denresu){
                            fMixto.Mensaje = "El resultado es un numero entero: "+fMixto.entero;
                        }else {
                            fMixto.Mensaje = "El resultado es un numero mixto: "+fMixto.entero + "  "+fMixto.suma+ "/"+fMixto.denresu;
                            
                        }
                    }else {
                        fMixto.Mensaje = "El resultado es una fraccion: "+fMixto.numresu+"/" + fMixto.denresu;
                    }
                }
                
            }

            return View("FDivision", fMixto);
        }
    }
}
