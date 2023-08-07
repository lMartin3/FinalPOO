using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Producto
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }
        public float Precio { get; private set; }
        public int Stock { get; private set; }
        public CategoriaProducto CategoriaProducto { get; private set; }
        public Producto(int id, string nombre, string descripcion, float precio, int stock, CategoriaProducto categoriaProducto)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Stock = stock;
            CategoriaProducto = categoriaProducto;
        }

        public override string ToString() {
            return Nombre;
        }
    }
}