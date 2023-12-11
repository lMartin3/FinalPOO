using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{

    /// <summary>
    /// Clase responsable de instanciar todas las controladoras necesarias y mantener sus referencias.
    /// Se utiliza como singleton para no convertir cada controladora individual en un singleton
    /// </summary>
    public class Papeleria
    {
        private static Papeleria instancia;

        public static Papeleria Instancia
        {
            get
            {
                if(instancia == null)
                {
                    instancia = new Papeleria();
                }
                return instancia;
            }
        }

        public ControladoraClientes Clientes;
        public ControladoraProductos Productos;


        private Papeleria()
        {
            this.Clientes = new ControladoraClientes();
            this.Productos = new ControladoraProductos();
        }
    }
}
