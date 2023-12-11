using Entidades;
using NuevoModelo;
using NuevoModelo.Util;

namespace Controladora
{
    public class ControladoraClientes
    {

        public IReadOnlyCollection<Cliente> ListarClientes()
        {
            return ContextoPapeleria.Instancia.Clientes.ToList().AsReadOnly();
        }

        public ResultadoOperacion CrearCliente(Cliente cliente)
        {
            if(!ValidacionUtil.EsDniOCuitValido(cliente.DniOCuit))
            {
                return ResultadoOperacion.fallo("DNI o CUIT inválido");
            }
            if (cliente.Nombre == "" || cliente.Direccion == "") 
                return ResultadoOperacion.fallo("Campos inválidos");

            if(ContextoPapeleria.Instancia.Clientes.Where(c=>c.DniOCuit.Equals(cliente.DniOCuit)).FirstOrDefault()!=null)
            {
                return ResultadoOperacion.fallo("Ya existe un Cliente con ese DNI / CUIT");
            }

            ContextoPapeleria.Instancia.Clientes.Add(cliente);
            ContextoPapeleria.Instancia.SaveChanges();
            return ResultadoOperacion.exitosa();
        }

        public ResultadoOperacion EliminarCliente(Cliente cliente)
        {
            // TODO checks de lógica
            ContextoPapeleria.Instancia.Clientes.Remove(cliente);
            ContextoPapeleria.Instancia.SaveChanges();
            return ResultadoOperacion.exitosa();
        }

    }
}