using Modelo.Dato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class OrdenCompra
    {
        public string NroOrden { get; set; }
        public Proveedor Proveedor { get; set; }
        public ListaDeItemsProducto listaItems { get; set; }

        public int CantidadItems
        {
            get => listaItems.itemsReadonly.Count;
        }

        public float Total
        {
            get {
                float totalItems = 0;
                foreach(ItemProducto item in listaItems.itemsReadonly)
                {
                    totalItems += item.PrecioUnitario;
                }
                return totalItems;
            }
        }
    }
}