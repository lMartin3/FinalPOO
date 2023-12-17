namespace Entidades
{
    public class Venta
    {
        public int VentaId { get; set; }
        public int NroVenta { get; set; }
        public DateTime Fecha { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemProducto> Items;

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

        public Venta()
        {
            Items = new List<ItemProducto>();
        }

        public float Total
        {
            get => Items.Select(i => i.Subtotal).Sum();
        }

        //TODO Ver si funca
        public string ResumenItems => String.Join(", ", Items.Select(item => item.Producto.Nombre).ToList());
    }
}