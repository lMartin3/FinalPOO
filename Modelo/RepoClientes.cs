using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class RepoClientes : Repositorio<Cliente>
    {
        protected override bool VerificarElemento(Cliente elementoAVerificar)
        {
            return true;
        }
    }
}