using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controladoras.Util;
using NuevoModelo;

namespace Controladoras
{
    public class ControladoraProveedores
    {

        public IReadOnlyCollection<Proveedor> ListarProveedores()
        {
            return ContextoPapeleria.Instancia.Proveedores.ToImmutableList();
        }

        public ResultadoOperacion CrearProveedor(Proveedor proveedor)
        {
            if (!ValidacionUtil.EsCuitValido(proveedor.Cuit))
            {
                return ResultadoOperacion.Fallo("CUIT inválido");
            }
            if (proveedor.RazonSocial == "" || proveedor.Direccion == "")
                return ResultadoOperacion.Fallo("Campos inválidos");

            if (ContextoPapeleria.Instancia.Proveedores.Where(c => c.Cuit.Equals(proveedor.Cuit)).FirstOrDefault() != null)
            {
                return ResultadoOperacion.Fallo("Ya existe un Cliente con ese DNI / CUIT");
            }

            if(proveedor.CondicionFiscal==CondicionFiscal.CONSUMIDOR_FINAL)
            {
                return ResultadoOperacion.Fallo("Un proveedor no puede estar registrado como consumidor final!");
            }

            ContextoPapeleria.Instancia.Proveedores.Add(proveedor);
            ContextoPapeleria.Instancia.SaveChanges();
            return ResultadoOperacion.Exitosa();
        }

        public Producto? BuscarPorNombre(string NombreProducto)
        {
            return ContextoPapeleria.Instancia.Productos.Where(p=>p.Nombre.Equals(NombreProducto)).FirstOrDefault();
        }
    }
}
