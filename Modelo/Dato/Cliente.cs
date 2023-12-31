﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Cliente
    {
        public string DniOCuit { get; private set; } //DNI o CUIT 
        public CondicionFiscal CondicionFiscal { get; private set; }
        public string Nombre { get; private set; }
        public string Direccion { get; private set; }
        
        public Cliente() { }
        
        public Cliente(string dni, CondicionFiscal condicionFiscal, string nombre, string direccion)
        {
            DniOCuit = dni;
            CondicionFiscal = condicionFiscal;
            Nombre = nombre;
            Direccion = direccion;
        }

        public override string ToString()
        {
            return Nombre;
        }


    }
}