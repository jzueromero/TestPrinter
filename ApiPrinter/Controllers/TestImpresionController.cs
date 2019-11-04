using ApiPrinter.Configuraciones;
using ApiPrinter.Models;
using ApiPrinter.ServiciosWebPrinter;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace ApiPrinter.Controllers
{
    public class TestImpresionController : ApiController
    {


        HelperConfig cf;
        PrintDocument Documento;
        HelperPrinterClass Impresor;
        public string PostImpresion(Documento texto)
        {
            cf = new HelperConfig();
            
            Impresor = new HelperPrinterClass();

            if (texto.Impresor == "Cocina" || texto.Impresor == "cocina")
            {
                Impresor.PrinterSettings.PrinterName = cf.Configuracion.ImpresoraCocina;
            }
            else
            {
                Impresor.PrinterSettings.PrinterName = cf.Configuracion.ImpresoraBar;
            }
            if (cf.Configuracion.UsarMargenes == 1)
            {
                Impresor.DefaultPageSettings.Margins.Left = cf.Configuracion.MargenIzquierdo;
                Impresor.DefaultPageSettings.Margins.Right = cf.Configuracion.MargenDerecho;
            }

            Impresor.PrinterFont = new Font(cf.Configuracion.Fuente, cf.Configuracion.NumeroFuente);
            Impresor.TextToPrint = texto.Contenido;
            Impresor.Print();
            return texto.Contenido;

        }


    }
}
