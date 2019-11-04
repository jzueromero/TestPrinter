using ApiPrinter.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace ApiPrinter.Configuraciones
{
    public class HelperConfig
    {
        private string DBnombre = System.Web.Hosting.HostingEnvironment.MapPath("~/Configuraciones/config.xml");
        XElement Documento;
        IEnumerable<XElement> configuraciones;
        public Configuracion Configuracion { get; set; }

        public HelperConfig()
        {
            try
            {
                if (!File.Exists(Path.GetFullPath(DBnombre)))
                {
                }
                else
                {
                    Configuracion = new Configuracion();
                    Documento = XElement.Load(DBnombre);
                    configuraciones = Documento.Elements();
                    int posicion = 0;
                    foreach (var confi in configuraciones)
                    {
                        var a = confi.Value;
                        switch (posicion)
                        {
                            case 0:
                                {
                                    Configuracion.ImpresoraCocina = confi.Value;
                                    break;
                                }
                            case 1:
                                {
                                    Configuracion.ImpresoraBar = confi.Value;
                                    break;
                                }
                            case 2:
                                {
                                    Configuracion.UsarMargenes = int.Parse(confi.Value);
                                    break;
                                }
                            case 3:
                                {
                                    Configuracion.MargenDerecho = int.Parse(confi.Value);
                                    break;
                                }
                            case 4:
                                {
                                    Configuracion.MargenIzquierdo = int.Parse(confi.Value);
                                    break;
                                }

                            case 5:
                                {
                                    Configuracion.Fuente = confi.Value;
                                    break;
                                }
                            case 6:
                                {
                                    Configuracion.NumeroFuente = int.Parse(confi.Value);
                                    break;
                                }
                        }
                        posicion++;
                    }

                }

            }
            catch (Exception e)
            {
                var a = e.Message;
            }
        }
    }
}