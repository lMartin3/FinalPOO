using Entidades;
using NuevoModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraOrdenesDeCompra
    {
        
        public ResultadoOperacion CrearOrdenDeCompra(OrdenCompra orden)
        {
            if(ContextoPapeleria.Instancia.OrdenesDeCompra.Where(c=>c.NroOrden == orden.NroOrden).FirstOrDefault()!=null)
            {
                return ResultadoOperacion.fallo("Ya existe una orden de compra con ese número!");
            }

            ResultadoOperacion checkItems = EvaluarItems(orden.Items.ToList());
            if(!checkItems.Exito)
            {
                return checkItems;
            }

            ContextoPapeleria.Instancia.OrdenesDeCompra.Add(orden);
            ContextoPapeleria.Instancia.SaveChanges();
            return ResultadoOperacion.exitosa();
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

            return ResultadoOperacion.exitosa();
        }

        private ResultadoOperacion EvaluarItem(ItemProducto item)
        {
            if (item.PrecioUnitario < 0)
            {
                return ResultadoOperacion.fallo($"El precio unitario de {item.Producto.Nombre} es negativo");
            }
            if (item.Cantidad <= 0)
            {
                return ResultadoOperacion.fallo($"La cantidad de {item.Producto.Nombre} debe ser mayor a 0!");
            }
            Producto? prod = ContextoPapeleria.Instancia.Productos.Where(p => p.Codigo == item.Producto.Codigo).FirstOrDefault();
            if (prod == null)
            {
                return ResultadoOperacion.fallo($"El producto {item.Producto.Nombre} es inválido!");
            }
            return ResultadoOperacion.exitosa();
        }
    }
}
