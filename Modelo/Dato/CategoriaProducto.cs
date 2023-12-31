﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class CategoriaProducto
    {
        public CategoriaProducto(int id, string nombre, string descripcion)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}