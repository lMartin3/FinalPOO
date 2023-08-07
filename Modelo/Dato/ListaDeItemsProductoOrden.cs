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
            //(TODO)no se si sigue las convenciones
            if (itemAEvaluar.Producto==null||
                itemAEvaluar.PrecioUnitario < 0 ||
                itemAEvaluar.Cantidad <= 0
            )
            {
                return false;
            }
            return true;
        }
    }
}
