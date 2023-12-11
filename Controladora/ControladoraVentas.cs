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
    public class ControladoraVentas
    {

        public IReadOnlyCollection<Venta> ListarVentas()
        {
            return ContextoPapeleria.Instancia.Ventas.ToImmutableList();
        }
        
        public ResultadoOperacion CrearVenta(Venta venta)
        {
            if(ContextoPapeleria.Instancia.Ventas.Where(v=>v.NroVenta == venta.NroVenta).FirstOrDefault()!=null)
            {
                return ResultadoOperacion.Fallo("Ya existe una venta con ese número!");
            }

            ResultadoOperacion checkProductos = EvaluarItems(venta.Items.ToList());
            if (!checkProductos.Exito)
            {
                return checkProductos;
            }

            ContextoPapeleria.Instancia.Ventas.Add(venta);
            ContextoPapeleria.Instancia.SaveChanges();
            
            return ResultadoOperacion.Exitosa();
        }

        public ResultadoOperacion ActualizarVenta(Venta venta)
        {
            ResultadoOperacion checkProductos = EvaluarItems(venta.Items.ToList());
            if (!checkProductos.Exito)
            {
                return checkProductos;
            }

            ContextoPapeleria.Instancia.Ventas.Update(venta);
            ContextoPapeleria.Instancia.SaveChanges();

            return ResultadoOperacion.Exitosa();
        }


        private ResultadoOperacion EvaluarItems(List<ItemProducto> items)
        {
            foreach(ItemProducto item in items)
            {
                ResultadoOperacion resultado = EvaluarItem(item);
                if (!resultado.Exito)
                {
                    return resultado;
                }
            }

            return ResultadoOperacion.Exitosa();
        }

        private ResultadoOperacion EvaluarItem(ItemProducto item)
        {
            if (item.PrecioUnitario < 0)
            {
                return ResultadoOperacion.Fallo($"El precio unitario de {item.Producto.Nombre} es negativo");
            }
            if (item.Cantidad <= 0)
            {
                return ResultadoOperacion.Fallo($"La cantidad de {item.Producto.Nombre} debe ser mayor a 0!");
            }

            //TODO fijarse esto
            int stockDisponible = Papeleria.Instancia.Productos.BuscarStockPorCodigo(item.Producto.Stock);
            if (stockDisponible < item.Cantidad)
            {
                return ResultadoOperacion.Fallo($"No hay suficiente stock de {item.Producto.Nombre}");
            }
            return ResultadoOperacion.Exitosa();
        }

    }
}
