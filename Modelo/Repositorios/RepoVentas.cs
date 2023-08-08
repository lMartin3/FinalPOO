using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class RepoVentas : Repositorio<Venta>
    {
        protected override bool PuedeAgregarElemento(Venta elementoAVerificar)
        {
            bool evaluacion =
                elementoAVerificar.Cliente!=null&&
                elementoAVerificar.Items.Count>0&&
                elementoAVerificar.Total>=0&&
                elementos.Where(c => c.Codigo == elementoAVerificar.Codigo).Count() == 0;
            return evaluacion;
        }
    }
}