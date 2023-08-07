using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class RepoProductos : Repositorio<Producto>
    {
        protected override bool PuedeAgregarElemento(Producto elementoAVerificar)
        {
            return true;
        }


        public Producto BuscarPorNombre(string nombre) {
            return elementos.Where(e=>e.Nombre == nombre).FirstOrDefault();
        }
    }
}