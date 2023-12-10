namespace Entidades
{
    public class ListaDeItemsProductoVenta : ListaDeItemsProducto
    {
        protected override bool EvaluarItem(ItemProducto itemAEvaluar)
        {
            Producto productoDelItem = itemAEvaluar.Producto;
            if (productoDelItem == null)
            {
                return false;
            }
            int stockUsadoEnVenta = ObtenerStockUtilizadoDeProducto(productoDelItem);

            return itemAEvaluar.PrecioUnitario >= 0
                && itemAEvaluar.Cantidad > 0
                && itemAEvaluar.Cantidad + stockUsadoEnVenta <= itemAEvaluar.Producto.Stock;
        }

      }
}
