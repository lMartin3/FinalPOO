using Entidades;

namespace NuevoModelo
{
    public class RepoProductos : Repositorio<Producto>
    {
        protected override bool PuedeAgregarElemento(Producto elementoAVerificar)
        {
            return elementos.Where(x=>x.Id == elementoAVerificar.Id).Count() == 0;
        }


        public Producto BuscarPorNombre(string nombre) {
            return elementos.Where(e=>e.Nombre == nombre).FirstOrDefault();
        }
    }
}