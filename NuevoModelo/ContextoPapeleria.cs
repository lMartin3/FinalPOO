using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NuevoModelo.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevoModelo
{
    public class ContextoPapeleria : DbContext
    {
        private static ContextoPapeleria instancia;

        public static ContextoPapeleria Instancia {
            get { 
                if(instancia == null)
                {
                    instancia = new ContextoPapeleria();
                }
                return instancia;
            } 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string connectionString;
            IConfigurationRoot configuration = ConfigurationHelper.GetConfiguration("appSettings.json");
            connectionString = configuration.GetConnectionString("DefaultConnection");
            options.UseSqlServer(connectionString);
        }
    }
}
