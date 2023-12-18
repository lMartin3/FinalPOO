using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.Reportes
{
    public abstract class GeneradorReportes
    {
        protected string datos;

        public abstract string Extension { get; }

        public abstract void CargarDatos(DateTime inicio, DateTime fin);

        public virtual bool Guardar(string path)
        {
            using(StreamWriter writer = new StreamWriter(path, false, Encoding.UTF8))
            {
                writer.Write(datos);
            }
            return true;
        }

    }
}
