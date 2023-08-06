﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class ItemVenta
    {
        public Producto Producto { get; private set;}
        public int Cantidad {get; private set;}
        public float PrecioUnitario {get; private set;}
        public ItemVenta(Producto producto, int cantidad, float precioUnitario)
        {
            Producto = producto;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
        }

    }
}