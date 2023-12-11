namespace Entidades
{
    public class Venta
    {
        public int NroVenta { get; private set; }
        public DateTime Fecha { get; private set; }
        public Cliente Cliente { get; private set; }
        private List<ItemProducto> Items;

        public Venta(int id, 
            DateTime fecha, 
            Cliente cliente,
            List<ItemProducto> items)
        {
            NroVenta = id;
            Fecha = fecha;
            Cliente = cliente;
            Items = items;
        }

        public float Total
        {
            get => Items.Select(i => i.Subtotal).Sum();
        }

        //TODO arreglar esto
        public string ResumenItems => "FIXME";

    }
}