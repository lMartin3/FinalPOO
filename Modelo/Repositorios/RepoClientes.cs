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
        protected override bool PuedeAgregarElemento(Cliente elementoAVerificar)
        {
            return ValidacionUtil.EsDniOCuitValido(elementoAVerificar.DniOCuit)
                && elementoAVerificar.Nombre != ""
                && elementoAVerificar.Direccion != ""
                && elementos.Where(c => c.DniOCuit == elementoAVerificar.DniOCuit).Count() == 0;
        }
    }
}