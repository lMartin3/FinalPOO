using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class RepoClientes : Repositorio<Cliente>
    {
        protected override bool PuedeAgregarElemento(Cliente elementoAVerificar)
        {
            return elementos.Where(c => c.Dni==elementoAVerificar.Dni).Count() == 0;
        }
    }
}