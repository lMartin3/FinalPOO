using Modelo.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Modelo
{
    public class RepoClientes : Repositorio<Cliente>
    {
        private static Regex dniRegex = new Regex("^[0-9]{8}$");
        private static Regex cuitRegex = new Regex("^[0-9]{11}$");
        protected override bool PuedeAgregarElemento(Cliente elementoAVerificar)
        {
            return dniRegex.IsMatch(elementoAVerificar.DniOCuit) 
                || cuitRegex.IsMatch(elementoAVerificar.DniOCuit)
                && elementoAVerificar.Nombre != ""
                && elementoAVerificar.Direccion != ""
                && elementos.Where(c => c.DniOCuit == elementoAVerificar.DniOCuit).Count() == 0;
        }
    }
}