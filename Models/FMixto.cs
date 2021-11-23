using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Matematicas.Models{

    public class FMixto{

        public int numerador {get;set;}
        public int denominador {get;set;}

        public int a {get;set;}

        public int entero{get;set;}

        public int suma {get;set;}
        
        
        public String Mensaje {get;set;}
    }
}