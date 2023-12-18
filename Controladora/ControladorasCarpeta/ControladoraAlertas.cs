using Controladoras;
using Entidades;
using NLog;
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
        private ResultadoOperacion EnviarAlerta(Producto producto, string mailGerente)
        {
            Logger logger = LogManager.GetLogger("");
            logger.PushScopeProperty("ToEmail", mailGerente);
            LogManager.AutoShutdown = true;
            //Hay que hacer este path relativo. Por algun motivo NLog no detecta su .config automaticamente ni por joda
            LogManager.Configuration = new NLog.Config.XmlLoggingConfiguration("D:\\SSD\\Estudio\\UAI\\UAI-2023\\2doCuatrimestre\\LUG2023\\Final\\Controladora\\NLog.config");
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
