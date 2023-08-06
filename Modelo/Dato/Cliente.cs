using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Cliente
    {
        public string Dni { get; set; } //DNI o CUIT 
        public CondicionFiscal CondicionFiscal { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        
        public Cliente() { }
        
        public Cliente(string dni, CondicionFiscal condicionFiscal, string nombre, string direccion)
        {
            Dni = dni;
            CondicionFiscal = condicionFiscal;
            Nombre = nombre;
            Direccion = direccion;
        }


    }
}