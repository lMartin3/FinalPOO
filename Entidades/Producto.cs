namespace Entidades
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }
        public int Stock { get; set; }
        public int UmbralStockBajo { get; set; }
        public int CategoriaProductoId { get; set; }
        public CategoriaProducto CategoriaProducto { get; set; }
        public Producto(int codigo, string nombre, string descripcion, float precio, int stock, int umbralStockBajo, CategoriaProducto categoriaProducto)
        {
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Stock = stock;
            CategoriaProducto = categoriaProducto;
            UmbralStockBajo = umbralStockBajo;
        }

        public Producto()
        {

        }

        public override string ToString() {
            return Nombre;
        }
    }
}