using Entidades;
using NuevoModelo.Util;

namespace NuevoModelo
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