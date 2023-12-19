﻿using Controladoras;
using Entidades;
using Microsoft.Extensions.Configuration;
using NLog;
using NuevoModelo.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuevoModelo.Util;


namespace Controladoras
{
    public class ControladoraAlertas
    {
        public string EmailDestinatario { get { return ObtenerEmailDestinatario(); } set { CambiarEmailDestinatario(value); } }

        private void CambiarEmailDestinatario(string newMail)
        {
            string directorioConfiguracion = ConfigurationHelper.DirectorioConfiguracion;

            if (!Directory.Exists(directorioConfiguracion))
            {
                Directory.CreateDirectory(directorioConfiguracion);
            }

            string filePath = Path.Combine(directorioConfiguracion, "email.txt");

            File.WriteAllText(filePath, newMail);
        }
        private string ObtenerEmailDestinatario()
        {
            string directorioConfiguracion = ConfigurationHelper.DirectorioConfiguracion;

            if (!Directory.Exists(directorioConfiguracion))
            {
                return "";
            }
            string filePath = Path.Combine(directorioConfiguracion, "email.txt");
            if (!File.Exists(filePath))
            {
                return "";
            }
            return File.ReadAllText(filePath);

        }
        public ControladoraAlertas() {
            LogManager.AutoShutdown = true;
            LogManager.Configuration = new NLog.Config.XmlLoggingConfiguration(Path.Join(ConfigurationHelper.DirectorioConfiguracion, "Nlog.config"));
        }

        public void CheckearProductosPorAlertas()
        {
            var productos = Papeleria.Instancia.Productos.ListarProductos();

            List<Producto> productosDeStockBajo = productos.Where(p => p.Stock < p.UmbralStockBajo).ToList();
            EnviarAlertaStockBajo(productosDeStockBajo);
        }

        private ResultadoOperacion EnviarAlertaStockBajo(List<Producto> productosStockBajo)
        {
            Logger logger = LogManager.GetLogger("");
            logger.PushScopeProperty("ToEmail", EmailDestinatario);
            
            Debug.WriteLine("ENVIANDO EMAIL! a " + EmailDestinatario);

            ResultadoOperacion res;
            try
            {
                string mensaje = "ATENCIÓN: \n";
                foreach (var producto in productosStockBajo)
                {
                    mensaje += $" -El producto \"{producto.Nombre}\" se encuentra con un stock muy bajo de \"{producto.Stock}\" unidades.\n";
                }

                logger.Info(mensaje);
                res = new ResultadoOperacion(true);
            }
            catch (Exception e)
            {
                res = new ResultadoOperacion(true, e.Message);
            }

            return res;
        }
    }
}
