using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Proveedor
    {
        private string _cuit;
        private CondicionFiscal _condicionFiscal;
        private string _razonSocial;
        private string _direccion;

        public string Cuit { get => _cuit; set => _cuit = value; }
        public CondicionFiscal CondicionFiscal { get => _condicionFiscal; set => _condicionFiscal = value; }
        public string RazonSocial { get => _razonSocial; set => _razonSocial = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }

    public override string ToString() {
        return RazonSocial;
    }
    }

}