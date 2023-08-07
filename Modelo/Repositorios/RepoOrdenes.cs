using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class RepoOrdenes : Repositorio<OrdenCompra>
    {
        protected override bool PuedeAgregarElemento(OrdenCompra elementoAVerificar)
        {
            return elementos.Where(x=>x.NroOrden==elementoAVerificar.NroOrden).Count() == 0;
        }
    }
}