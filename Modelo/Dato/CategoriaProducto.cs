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
            _id = id;
            _nombre = nombre;
            _descripcion = descripcion;
        }
    }
}