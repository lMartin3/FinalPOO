using Modelo.Dato;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Venta
    {
        public int Codigo { get; private set; }
        public DateTime Fecha { get; private set; }
        public Cliente Cliente { get; private set; }
        public ListaDeItemsProducto listaItems;

        //(TODO) no se si sigue los estandares
        public Venta(int id = 0, 
            DateTime fecha = new DateTime(), 
            Cliente cliente = null,
            ListaDeItemsProducto items = null)
        {
            Codigo = id;
            Fecha = fecha;
            Cliente = cliente;
            listaItems = items;
        }

        public float Total
        {
            get
            {
                float totalItems = 0;
                foreach (ItemProducto item in listaItems.itemsReadonly)
                {
                    totalItems += item.PrecioUnitario;
                }
                return totalItems;
            }
        }
    }
}