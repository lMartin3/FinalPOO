using Controladoras;
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

namespace Controladoras
{
    public class ControladoraAlertas
    {
        public string EmailDestinatario { get { return ObtenerEmailDestinatario(); } set { CambiarEmailDestinatario(value); } }

        private void CambiarEmailDestinatario(string newMail)
        {
            string appDataRoamingPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PapeleriaLUG");

            if (!Directory.Exists(appDataRoamingPath))
            {
                Directory.CreateDirectory(appDataRoamingPath);
            }

            string filePath = Path.Combine(appDataRoamingPath, "email.txt");

            File.WriteAllText(filePath, "Hello, World!");

            // Read the variable from the file
        }
        private string ObtenerEmailDestinatario()
        {
            string appDataRoamingPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PapeleriaLUG");

            if (!Directory.Exists(appDataRoamingPath))
            {
                return "";
            }
            string filePath = Path.Combine(appDataRoamingPath, "email.txt");
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
        
            foreach(Producto producto in productos)
            {
                if (producto.Stock < producto.UmbralStockBajo)
                {
                    EnviarAlertaStockBajo(producto);
                }
            }
        }

        private ResultadoOperacion EnviarAlertaStockBajo(Producto producto)
        {
            Logger logger = LogManager.GetLogger("");
            logger.PushScopeProperty("ToEmail", EmailDestinatario);
            
            System.Diagnostics.Debug.WriteLine("ENVIANDO EMAIL! a "+ EmailDestinatario);

            ResultadoOperacion res;
            try
            {
                logger.Info("ATENCIÓN: El producto \"{nombreProducto}\" se encuentra con un stock muy bajo de \"{stockProducto}\" unidades.", producto.Nombre, producto.Stock);
                res = new ResultadoOperacion(true);
            }
            catch (Exception e)
            {
                res = new ResultadoOperacion(true, e.Message);
            }
            finally
            {
                LogManager.Shutdown();
            }

            return res;
        }
    }
}
