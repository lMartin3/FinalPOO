using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class OrdenCompra
    {
        public int NroOrden { get; set; }
        public Proveedor Proveedor { get; set; }
        public List<ItemCompra> Items { get; set; }

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