using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Dato
{
    public class ListaDeItemsProducto
    {
        public List<ItemProducto> items = new List<ItemProducto>();
        public ReadOnlyCollection<ItemProducto> itemsReadonly => items.AsReadOnly();

        public ListaDeItemsProducto(List<ItemProducto> items = null)
        {
            if (items == null) 
            {
                items = new List<ItemProducto>();
            }
            this.items = items;
        }

        public int ObtenerStockUtilizadoDeProducto(Producto producto)
        {
            return itemsReadonly.Where(itm => itm.Producto == producto)
                .Sum(itm => itm.Cantidad);
        }

        public bool AddItemVenta(ItemProducto itemAAgregar)
        {
            Producto productoDelItem = itemAAgregar.Producto;
            if (productoDelItem == null)
            {
                return false;
            }

            //(TODO)no se si sigue las convenciones nada de esto
            int stockUsadoEnVenta = ObtenerStockUtilizadoDeProducto(productoDelItem);

            if (itemAAgregar.PrecioUnitario < 0 ||
               itemAAgregar.Cantidad <= 0 ||
               itemAAgregar.Cantidad + stockUsadoEnVenta > itemAAgregar.Producto.Stock
               )
            {
                return false;
            }
            items.Add(itemAAgregar);
            return true;
        }

        public void RemoverItem(ItemProducto itemARemover)
        {
            items.Remove(itemARemover);
        }
        public void RemoverItemEn(int indice)
        {
            items.RemoveAt(indice);
        }

    }
}
