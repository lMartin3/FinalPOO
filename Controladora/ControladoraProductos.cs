using Entidades;
using NuevoModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraProductos
    {
        
        public ResultadoOperacion CrearProducto(Producto producto)
        {
            if(ContextoPapeleria.Instancia.Productos.Where(p=>p.Codigo == producto.Codigo).FirstOrDefault()!=null)
            {
                return ResultadoOperacion.fallo("Ya existe un producto con ese código!");
            }

            ContextoPapeleria.Instancia.Productos.Add(producto);
            ContextoPapeleria.Instancia.SaveChanges();
            return ResultadoOperacion.exitosa();
        }

        public Producto? BuscarPorNombre(string NombreProducto)
        {
            return ContextoPapeleria.Instancia.Productos.Where(p=>p.Nombre.Equals(NombreProducto)).FirstOrDefault();
        }
    }
}
