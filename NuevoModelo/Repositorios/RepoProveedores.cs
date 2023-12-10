using Entidades;
using NuevoModelo.Util;

namespace NuevoModelo
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