using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class RepoCategorias : Repositorio<CategoriaProducto>
    {
        protected override bool PuedeAgregarElemento(CategoriaProducto elementoAVerificar)
        {
            return elementos.Where(c => c.Id==elementoAVerificar.Id).Count() == 0;
        }
    }
}