namespace Entidades
{
    public class ItemProducto
    {
        public int ItemProductoId { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set;}
        public int Cantidad {get; set;}
        public float PrecioUnitario {get; set;}
        public float CantidadAlerta { get; set; }
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