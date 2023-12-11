namespace Entidades
{
    public class Venta
    {
        public int NroVenta { get; private set; }
        public DateTime Fecha { get; private set; }
        public Cliente Cliente { get; private set; }
        private ListaDeItemsProductoVenta _listaItems;

        public Venta(int id, 
            DateTime fecha, 
            Cliente cliente,
            ListaDeItemsProductoVenta items)
        {
            NroVenta = id;
            Fecha = fecha;
            Cliente = cliente;
            _listaItems = items;
        }

        public float Total
        {
            get
            {
                float totalItems = 0;
                foreach (ItemProducto item in _listaItems.itemsReadonly)
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