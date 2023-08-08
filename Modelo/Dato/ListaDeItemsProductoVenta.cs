using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Dato
{
    public class ListaDeItemsProductoVenta : ListaDeItemsProducto
    {
        protected override bool EvaluarItem(ItemProducto itemAEvaluar)
        {
            Producto productoDelItem = itemAEvaluar.Producto;
            if (productoDelItem == null)
            {
                return false;
            }
            int stockUsadoEnVenta = ObtenerStockUtilizadoDeProducto(productoDelItem);

            return itemAEvaluar.PrecioUnitario >= 0
                && itemAEvaluar.Cantidad > 0
                && itemAEvaluar.Cantidad + stockUsadoEnVenta <= itemAEvaluar.Producto.Stock;
        }

      }
}
