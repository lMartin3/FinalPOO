using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Venta
    {
        private int Id { get; set; }
        private DateTime Fecha { get; set; }
        private Cliente Cliente { get; set; }
        private List<ItemVenta> Items { get; set; }
        public ReadOnlyCollection<ItemVenta> itemsReadonly => Items.AsReadOnly();

        //(TODO) no se si sigue los estandares
        public Venta(int id = 0, 
            DateTime fecha = new DateTime(), 
            Cliente cliente = null, 
            List<ItemVenta> items = null)
        {
            Id = id;
            Fecha = fecha;
            Cliente = cliente;
            if (items == null)
            {
                items = new List<ItemVenta>();
            }
            Items = items;
        }

        public float CalcularPrecioTotal()
        {
            float precio = 0;
            foreach(ItemVenta item in Items)
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
            Items.Add(itemAAgregar);
            return true;
        }
        public bool EliminarItem(ItemVenta item)
        {
            return Items.Remove(item);
        }
        public void LimpiarItems()
        {
            Items.Clear();
        }

        public int ObtenerStockUtilizadoDeProducto(Producto producto)
        {
            return Items.Where(itm => itm.Producto == producto)
                .Sum(itm => itm.Cantidad);
        }
    }
}