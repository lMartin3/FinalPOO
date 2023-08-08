using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Dato
{
    public class ListaDeItemsProductoOrden : ListaDeItemsProducto
    {
        protected override bool EvaluarItem(ItemProducto itemAEvaluar)
        {
            return itemAEvaluar.Producto != null
                && itemAEvaluar.PrecioUnitario >= 0
                && itemAEvaluar.Cantidad > 0;
        }
    }
}
