using Entidades;
using NuevoModelo;
using NuevoModelo.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraProveedores
    {
        
        public ResultadoOperacion CrearProveedor(Proveedor proveedor)
        {
            if (!ValidacionUtil.EsCuitValido(proveedor.Cuit))
            {
                return ResultadoOperacion.fallo("CUIT inválido");
            }
            if (proveedor.RazonSocial == "" || proveedor.Direccion == "")
                return ResultadoOperacion.fallo("Campos inválidos");

            if (ContextoPapeleria.Instancia.Proveedores.Where(c => c.Cuit.Equals(proveedor.Cuit)).FirstOrDefault() != null)
            {
                return ResultadoOperacion.fallo("Ya existe un Cliente con ese DNI / CUIT");
            }

            if(proveedor.CondicionFiscal==CondicionFiscal.CONSUMIDOR_FINAL)
            {
                return ResultadoOperacion.fallo("Un proveedor no puede estar registrado como consumidor final!");
            }

            ContextoPapeleria.Instancia.Proveedores.Add(proveedor);
            ContextoPapeleria.Instancia.SaveChanges();
            return ResultadoOperacion.exitosa();
        }

        public Producto? BuscarPorNombre(string NombreProducto)
        {
            return ContextoPapeleria.Instancia.Productos.Where(p=>p.Nombre.Equals(NombreProducto)).FirstOrDefault();
        }
    }
}
