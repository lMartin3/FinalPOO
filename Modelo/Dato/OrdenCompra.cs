using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class OrdenCompra
    {
        private int _nroOrden;
        private Proveedor _proveedor;
        private List<ItemCompra> _items;

        public int NroOrden { get => _nroOrden; set => _nroOrden = value; }
        public Proveedor Proveedor { get => _proveedor; set => _proveedor = value; }
        public List<ItemCompra> Items { get => _items; set => _items = value; }

        public int CantidadItems
        {
            get => Items.Count;
        }

        public float Total
        {
            get {
                float totalItems = 0;
                foreach(ItemCompra item in  Items)
                {
                    totalItems += item.PrecioUnitario;
                }
                return totalItems;
            }
        }
    }
}