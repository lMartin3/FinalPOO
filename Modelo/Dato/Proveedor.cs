using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Proveedor
    {

        public string Cuit { get; private set; }
        public CondicionFiscal CondicionFiscal { get; private set; }
        public string RazonSocial { get; private set; }
        public string Direccion { get; private set; }

        public Proveedor(string cuit,
            CondicionFiscal condicionFiscal,
            string razonSocial,
            string direccion)
        {
            Cuit = cuit;
            CondicionFiscal = condicionFiscal;
            RazonSocial = razonSocial;
            Direccion = direccion;
        }


        public override string ToString()
        {
            return RazonSocial;
        }
    }

}