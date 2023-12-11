namespace Entidades
{
    public class Producto
    {
        public int Codigo { get; private set; }
        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }
        public float Precio { get; private set; }
        public int Stock { get; set; }
        public CategoriaProducto CategoriaProducto { get; private set; }
        public Producto(int codigo, string nombre, string descripcion, float precio, int stock, CategoriaProducto categoriaProducto)
        {
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Stock = stock;
            CategoriaProducto = categoriaProducto;
        }

        public override string ToString() {
            return Nombre;
        }

        public void SubstraerStock(int stockASubstraer)
        {
            if (Stock < stockASubstraer) return;
            Stock -= stockASubstraer;
        }
    }
}