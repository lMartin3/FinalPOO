using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Producto
    {
        private int _id;
        private string _nombre;
        private string _descripcion;
        private float _precio;
        private int _stock;
        private CategoriaProducto _categoriaProducto;
    }
}