using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NuevoModelo
{
    public class RepoVentas : Repositorio<Venta>
    {
        protected override bool PuedeAgregarElemento(Venta elementoAVerificar)
        {
            return elementoAVerificar.Cliente != null
                && elementoAVerificar.Items.Count > 0
                && elementoAVerificar.Total >= 0
                && elementos.Where(c => c.NroVenta == elementoAVerificar.NroVenta).Count() == 0;
        }
    }
}