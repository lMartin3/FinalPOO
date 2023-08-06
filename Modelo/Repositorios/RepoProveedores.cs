using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class RepoProveedores : Repositorio<Proveedor>
    {
        protected override bool VerificarElemento(Proveedor elementoAVerificar)
        {
            return true;
        }
    }
}