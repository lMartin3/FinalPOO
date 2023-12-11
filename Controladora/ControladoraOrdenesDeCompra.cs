using Entidades;
using NuevoModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraOrdenesDeCompra
    {
        
        public ResultadoOperacion CrearOrdenDeCompra(OrdenCompra orden)
        {
            if(ContextoPapeleria.Instancia.OrdenesDeCompra.Where(c=>c.NroOrden == orden.NroOrden).FirstOrDefault()!=null)
            {
                return ResultadoOperacion.fallo("Ya existe una orden de compra con ese número!");
            }

            ContextoPapeleria.Instancia.OrdenesDeCompra.Add(orden);
            ContextoPapeleria.Instancia.SaveChanges();
            return ResultadoOperacion.exitosa();
        }
    }
}
