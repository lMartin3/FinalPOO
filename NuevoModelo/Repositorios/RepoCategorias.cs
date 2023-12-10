using Entidades;

namespace NuevoModelo
{
    public class RepoCategorias : Repositorio<CategoriaProducto>
    {
        protected override bool PuedeAgregarElemento(CategoriaProducto elementoAVerificar)
        {
            return elementos.Where(c => c.Id == elementoAVerificar.Id).Count() == 0;
        }
    }
}