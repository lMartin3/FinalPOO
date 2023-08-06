using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class RepoVentas : Repositorio<Venta>
    {
        protected override bool VerificarElemento(Venta elementoAVerificar)
        {
            return true;
        }
    }
}