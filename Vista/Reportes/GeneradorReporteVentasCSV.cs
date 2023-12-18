using Controladoras;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.Reportes
{
    internal class GeneradorReporteVentasCSV : GeneradorReportes
    {
        public override string Extension { get => "csv"; }


        public override void CargarDatos(DateTime inicio, DateTime fin)
        {
            string resultado = "Fecha;NroVenta;NombreCliente;DocumentoCliente;Resumen;Importe";
            IReadOnlyCollection<Venta> ventas = Papeleria.Instancia.Ventas.ListarVentasEnPeriodo(inicio, fin);
            foreach(Venta venta in ventas)
            {
                resultado += $"\n{venta.Fecha.ToString("dd/MM/yyyy")};{venta.NroVenta};{venta.Cliente.Nombre};{venta.Cliente.DniOCuit};{venta.ResumenItems};{venta.Total}";
            }

            this.datos = resultado;

        }
    }
}
