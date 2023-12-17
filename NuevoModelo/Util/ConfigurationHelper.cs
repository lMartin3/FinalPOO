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
        public static IConfigurationRoot GetConfiguration(string fileName)
        {

            var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"PapeleriaLUG");
            var builder = new ConfigurationBuilder()
                .SetBasePath(dir)
                .AddJsonFile(fileName, optional: true, reloadOnChange: true);
            System.Diagnostics.Debug.WriteLine($"Leyendo configuración desde: {dir}");
            return builder.Build();
        }
    }
}
