using Entidades;

namespace NuevoModelo
{
    public class RepoOrdenes : Repositorio<OrdenCompra>
    {
        protected override bool PuedeAgregarElemento(OrdenCompra elementoAVerificar)
        {
            return elementos.Where(x=>x.NroOrden == elementoAVerificar.NroOrden).Count() == 0;
        }
    }
}