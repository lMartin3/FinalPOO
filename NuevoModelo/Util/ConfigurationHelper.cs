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
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(fileName, optional: true, reloadOnChange: true);
            return builder.Build();
        }
    }
}
