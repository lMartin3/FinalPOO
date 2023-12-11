namespace Entidades
{
    public class ItemProducto
    {
        public int ItemProductoId { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; private set;}
        public int Cantidad {get; private set;}
        public float PrecioUnitario {get; private set;}
        public ItemProducto(Producto producto, int cantidad, float precioUnitario)
        {
            Producto = producto;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
        }
        public ItemProducto() { }

        public float Subtotal => PrecioUnitario * Cantidad;

    }
}