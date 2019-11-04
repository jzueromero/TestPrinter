using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiPrinter.Models
{
    public class Configuracion
    {
        public string ImpresoraCocina { get; set; }
        public string ImpresoraBar { get; set; }
        public int MargenDerecho { get; set; }
        public int MargenIzquierdo { get; set; }
        public int UsarMargenes { get; set; }
        public string Fuente { get; set; }
        public int NumeroFuente { get; set; }
    }
}