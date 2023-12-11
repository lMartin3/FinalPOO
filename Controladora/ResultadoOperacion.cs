using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ResultadoOperacion
    {
        public readonly bool Exito;
        public readonly string? Mensaje;

        public ResultadoOperacion(bool exito, string mensaje) {
            this.Exito = exito;
            this.Mensaje = mensaje;
        }

        public ResultadoOperacion(bool exito)
        {
            this.Exito = exito;
        }

        public static ResultadoOperacion Exitosa()
        {
            return new ResultadoOperacion(true);
        }

        public static ResultadoOperacion Fallo(string mensaje)
        {
            return new ResultadoOperacion(false, mensaje);
        }
    }
}
