using Entidades;
using NuevoModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraCategorias
    {
        
        public ResultadoOperacion CrearCategoria(CategoriaProducto categoria)
        {
            if(ContextoPapeleria.Instancia.Categorias.Where(c=>c.Codigo == categoria.Codigo).FirstOrDefault()!=null)
            {
                return ResultadoOperacion.fallo("Ya existe una categoría con ese código!");
            }

            ContextoPapeleria.Instancia.Categorias.Add(categoria);
            ContextoPapeleria.Instancia.SaveChanges();
            return ResultadoOperacion.exitosa();
        }
    }
}
