using Entidades;
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

        public ContextoPapeleria() : base()
        {

        }

        public DbSet<CategoriaProducto> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }  
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<OrdenCompra> OrdenesDeCompra { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            base.OnConfiguring(options);
            string connectionString;
            IConfigurationRoot configuration = ConfigurationHelper.GetConfiguration("appSettings.json");
            connectionString = configuration.GetConnectionString("DefaultConnection");
            options.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Registrar restricción (constraint) de DB de DNI / CUIT único
            modelBuilder.Entity<Cliente>().HasIndex(c => c.DniOCuit).IsUnique();
        }

    }
}
