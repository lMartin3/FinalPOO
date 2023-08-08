using Modelo.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Modelo
{
    public class RepoProveedores : Repositorio<Proveedor>
    {

        protected override bool PuedeAgregarElemento(Proveedor elementoAVerificar)
        {
            
            return ValidacionUtil.EsCuitValido(elementoAVerificar.Cuit)
                && elementoAVerificar.RazonSocial != ""
                && elementoAVerificar.Direccion != ""
                && elementoAVerificar.CondicionFiscal!=CondicionFiscal.CONSUMIDOR_FINAL;
        }
    }
}