namespace Entidades
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
