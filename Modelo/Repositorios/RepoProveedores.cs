using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Modelo
{
    public class RepoProveedores : Repositorio<Proveedor>
    {
        private static Regex cuitRegex = new Regex("^[0-9]{11}$");

        protected override bool PuedeAgregarElemento(Proveedor elementoAVerificar)
        {
            bool evaluacion=
                cuitRegex.IsMatch(elementoAVerificar.Cuit) &&
                elementoAVerificar.RazonSocial != "" &&
                elementoAVerificar.Direccion != "" &&
                elementoAVerificar.CondicionFiscal!=CondicionFiscal.CONSUMIDOR_FINAL;
            return evaluacion;
        }
    }
}