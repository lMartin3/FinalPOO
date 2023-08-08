using Modelo.Dato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class OrdenCompra
    {
        public string NroOrden { get; private set; }
        public Proveedor Proveedor { get; private set; }
        public ListaDeItemsProducto ListaItems { get; private set; }


        public OrdenCompra(string nroOrden, Proveedor proveedor, ListaDeItemsProducto listaItems)
        {
            NroOrden = nroOrden;
            Proveedor = proveedor;
            ListaItems = listaItems;
        }

        public int CantidadItems
        {
            get => ListaItems.itemsReadonly.Count;
        }

        public float Total
        {
            get {
                float totalItems = 0;
                foreach(ItemProducto item in ListaItems.itemsReadonly)
                {
                    totalItems += item.PrecioUnitario;
                }
                return totalItems;
            }
        }
    }
}