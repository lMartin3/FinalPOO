using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class CategoriaProducto
    {
        private int _id;
        private string _nombre;
        private string _descripcion;

        public CategoriaProducto(int id, string nombre, string descripcion)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}