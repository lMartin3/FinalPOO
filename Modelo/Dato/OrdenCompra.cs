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
        private ListaDeItemsProductoOrden _listaItems; 


        public OrdenCompra(string nroOrden,
            Proveedor proveedor,
            ListaDeItemsProductoOrden listaItems)
        {
            NroOrden = nroOrden;
            Proveedor = proveedor;
            _listaItems = listaItems;
        }

        public int CantidadItems
        {
            get => _listaItems.itemsReadonly.Count;
        }

        public float Total
        {
            get {
                float totalItems = 0;
                foreach(ItemProducto item in _listaItems.itemsReadonly)
                {
                    totalItems += item.PrecioUnitario;
                }
                return totalItems;
            }
        }

        public IReadOnlyCollection<ItemProducto> Items => _listaItems.itemsReadonly;

        public string ResumenItems => _listaItems.ResumenItems;
    } 
    
}