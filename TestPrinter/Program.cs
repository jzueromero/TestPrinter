
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPrinter.Servicios;

namespace TestPrinter
{
    class Program
    {
        static void Main(string[] args)
        {

            //string CadenaBold = "Titulo del documento a imprimir";
            

            PrintDocument Documento = new PrintDocument();
            ImpresorHelperClass Impresor = new ImpresorHelperClass();

             

            Impresor.PrinterSettings.PrinterName = "Microsoft XPS Document Writer";
            Impresor.PrinterFont = new Font("Verdana", 8);
            Impresor.TextToPrint = " Texto a imprimir";
            Impresor.Print();
            Console.ReadKey();

            PrintDocument DocumentoDos = new PrintDocument();

            Console.ReadKey();
          
        }
    }
}
