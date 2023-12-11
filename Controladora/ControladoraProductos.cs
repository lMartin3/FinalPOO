using Entidades;
using NuevoModelo;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraProductos
    {

        public IReadOnlyCollection<Producto> ListarProductos()
        {
            return ContextoPapeleria.Instancia.Productos.ToImmutableList();
        }

        public ResultadoOperacion CrearProducto(Producto producto)
        {
            if (ContextoPapeleria.Instancia.Productos.Where(p => p.Codigo == producto.Codigo).FirstOrDefault() != null)
            {
                return ResultadoOperacion.fallo("Ya existe un producto con ese código!");
            }

            ContextoPapeleria.Instancia.Productos.Add(producto);
            ContextoPapeleria.Instancia.SaveChanges();
            return ResultadoOperacion.exitosa();
        }

        public Producto? BuscarPorCodigo(int codigoProducto)
        {
            return ContextoPapeleria.Instancia.Productos.Where(p=>p.Codigo== codigoProducto).FirstOrDefault();
        }

        public int BuscarStockPorCodigo(int codigoProducto)
        {
            Producto? producto = BuscarPorCodigo(codigoProducto);
            if (producto == null) return 0;
            return producto.Stock;
        }

        public Producto? BuscarPorNombre(string NombreProducto)
        {
            return ContextoPapeleria.Instancia.Productos.Where(p => p.Nombre.Equals(NombreProducto)).FirstOrDefault();
        }

        public ResultadoOperacion ActualizarProducto(Producto producto)
        {
            Producto datosViejosProducto = ContextoPapeleria.Instancia.Productos.Where(p => p.Codigo == producto.Codigo).FirstOrDefault();
            if (datosViejosProducto == null)
            {
                return ResultadoOperacion.fallo("No se pudo encontrar el producto");
            }
            if(producto.Stock<0)
            {
                return ResultadoOperacion.fallo("El stock no puede ser negativo");
            }

            ContextoPapeleria.Instancia.Productos.Update(producto);
            ContextoPapeleria.Instancia.SaveChanges();
            return ResultadoOperacion.exitosa();
        }

        public ResultadoOperacion AumentarStockProducto(int codigoProducto, int diferenciaStock)
        {
            Producto? producto = BuscarPorCodigo(codigoProducto);
            if (producto == null) return ResultadoOperacion.fallo("No se pudo encontrar el producto");
            producto.Stock += diferenciaStock;
            return ActualizarProducto(producto);
        }
    }
}
