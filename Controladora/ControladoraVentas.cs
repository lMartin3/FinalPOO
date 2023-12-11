using Entidades;
using NuevoModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraVentas
    {
        
        public ResultadoOperacion CrearVenta(Venta venta)
        {
            if(ContextoPapeleria.Instancia.Ventas.Where(v=>v.NroVenta == venta.NroVenta).FirstOrDefault()!=null)
            {
                return ResultadoOperacion.fallo("Ya existe una venta con ese código!");
            }

            ContextoPapeleria.Instancia.Categorias.Add(venta);
            ContextoPapeleria.Instancia.SaveChanges();
            return ResultadoOperacion.exitosa();
        }
    }
}
