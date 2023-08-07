using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class RepoProveedores : Repositorio<Proveedor>
    {
        protected override bool PuedeAgregarElemento(Proveedor elementoAVerificar)
        {
            return true;
        }
    }
}