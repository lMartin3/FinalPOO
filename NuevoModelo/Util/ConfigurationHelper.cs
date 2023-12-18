using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevoModelo.Util
{
    public static class ConfigurationHelper
    {

        public static readonly string DirectorioConfiguracion = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"PapeleriaLUG");
        public static IConfigurationRoot GetConfiguration(string fileName)
        {

            var builder = new ConfigurationBuilder()
                .SetBasePath(DirectorioConfiguracion)
                .AddJsonFile(fileName, optional: true, reloadOnChange: true);
            System.Diagnostics.Debug.WriteLine($"Leyendo configuración desde: {DirectorioConfiguracion}");
            return builder.Build();
        }
    }
}
