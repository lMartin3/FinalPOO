using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Venta
    {
        private int _id;
        private DateTime _fecha;
        private Cliente _cliente;
        private List<ItemVenta> _items;
        public ReadOnlyCollection<ItemVenta> itemsReadonly => _items.AsReadOnly();

        //(TODO) no se si sigue los estandares
        public Venta(int id = 0, 
            DateTime fecha = new DateTime(), 
            Cliente cliente = null, 
            List<ItemVenta> items = null)
        {
            _id = id;
            _fecha = fecha;
            _cliente = cliente;
            if (items == null)
            {
                items = new List<ItemVenta>();
            }
            _items = items;
        }

        public float CalcularPrecioTotal()
        {
            float precio = 0;
            foreach(ItemVenta item in _items)
            {
                precio += item.PrecioUnitario * item.Cantidad;
            }
            return precio;
        }

        public bool AddItemVenta(ItemVenta itemAAgregar)
        {
            Producto productoDelItem = itemAAgregar.Producto;
            if (productoDelItem == null)
            {
                return false;
            }

            //(TODO)no se si sigue las convenciones nada de esto
            int stockUsadoEnVenta = ObtenerStockUtilizadoDeProducto(productoDelItem);

            if (itemAAgregar.PrecioUnitario<0 ||
               itemAAgregar.Cantidad<=0 ||
               itemAAgregar.Cantidad + stockUsadoEnVenta > itemAAgregar.Producto.Stock
               )
            {
                return false;
            }
            _items.Add(itemAAgregar);
            return true;
        }
        public bool EliminarItem(ItemVenta item)
        {
            return _items.Remove(item);
        }
        public void LimpiarItems()
        {
            _items.Clear();
        }

        public int ObtenerStockUtilizadoDeProducto(Producto producto)
        {
            return _items.Where(itm => itm.Producto == producto)
                .Sum(itm => itm.Cantidad);
        }
    }
}