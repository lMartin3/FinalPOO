using Entidades;

namespace NuevoModelo
{
    public class RepoCategorias : Repositorio<CategoriaProducto>
    {
        protected override bool PuedeAgregarElemento(CategoriaProducto elementoAVerificar)
        {
            return elementos.Where(c => c.Codigo == elementoAVerificar.Codigo).Count() == 0;
        }
    }
}