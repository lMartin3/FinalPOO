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
    public class ControladoraOrdenesDeCompra
    {

        public IReadOnlyCollection<OrdenCompra> ListarVentas()
        {
            return ContextoPapeleria.Instancia.OrdenesDeCompra.ToImmutableList();
        }
        public ResultadoOperacion CrearOrdenDeCompra(OrdenCompra orden)
        {
            if(ContextoPapeleria.Instancia.OrdenesDeCompra.Where(c=>c.NroOrden == orden.NroOrden).FirstOrDefault()!=null)
            {
                return ResultadoOperacion.Fallo("Ya existe una orden de compra con ese número!");
            }

            ResultadoOperacion checkItems = EvaluarItems(orden.Items.ToList());
            if(!checkItems.Exito)
            {
                return checkItems;
            }

            ContextoPapeleria.Instancia.OrdenesDeCompra.Add(orden);
            ContextoPapeleria.Instancia.SaveChanges();
            return ResultadoOperacion.Exitosa();
        }


        private ResultadoOperacion EvaluarItems(List<ItemProducto> items)
        {
            foreach (ItemProducto item in items)
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
            Producto? prod = ContextoPapeleria.Instancia.Productos.Where(p => p.Codigo == item.Producto.Codigo).FirstOrDefault();
            if (prod == null)
            {
                return ResultadoOperacion.Fallo($"El producto {item.Producto.Nombre} es inválido!");
            }
            return ResultadoOperacion.Exitosa();
        }
    }
}
