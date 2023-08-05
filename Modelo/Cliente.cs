using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Cliente
    {
        private long _dni; //DNI o CUIT
        private CondicionFiscal _condicionFiscal;
        private string _nombre;
        private string _direccion;

        public Cliente(long dni, CondicionFiscal condicionFiscal, string nombre, string direccion)
        {
            _dni = dni;
            _condicionFiscal = condicionFiscal;
            _nombre = nombre;
            _direccion = direccion;
        }
    }
}