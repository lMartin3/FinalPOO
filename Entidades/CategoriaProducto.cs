namespace Entidades
{
    public class CategoriaProducto
    {
        public CategoriaProducto() { }

        public CategoriaProducto(int codigo, string nombre, string descripcion)
        {
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public int CategoriaProductoId { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}