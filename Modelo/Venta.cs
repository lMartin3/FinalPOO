using System;
using System.Collections.Generic;
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
    }
}