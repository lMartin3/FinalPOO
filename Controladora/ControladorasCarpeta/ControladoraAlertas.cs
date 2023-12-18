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

namespace Controladoras
{
    public class ControladoraAlertas
    {

        public ControladoraAlertas() {
            LogManager.AutoShutdown = true;
            LogManager.Configuration = new NLog.Config.XmlLoggingConfiguration(Path.Join(ConfigurationHelper.DirectorioConfiguracion, "Nlog.config"));
        }

        public ResultadoOperacion EnviarAlerta(Producto producto, string mailGerente)
        {
            Logger logger = LogManager.GetLogger("");
            logger.PushScopeProperty("ToEmail", mailGerente);
            System.Diagnostics.Debug.WriteLine("ENVIANDO EMAIL!");

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
