using Controladoras;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.Reportes
{
    public class GeneradorReporteVentasHTML : GeneradorReportes
    {
        public override string Extension => "html";

        public override void CargarDatos(DateTime inicio, DateTime fin)
        {
            if (inicio > fin) return;

            IReadOnlyCollection<Venta> ventas = Papeleria.Instancia.Ventas.ListarVentasEnPeriodo(inicio, fin); ;
            if (ventas.Count == 0) return;

            string plantillaHtml = Properties.Resources.Plantilla;

            plantillaHtml = plantillaHtml.Replace("@DESDE", inicio.ToString("dd/MM/yyyy"));
            plantillaHtml = plantillaHtml.Replace("@HASTA", fin.ToString("dd/MM/yyyy"));

            Dictionary<CategoriaProducto, double> totalPorCategoria = Papeleria.Instancia.Ventas.ListarIngresosPorCategoriaEnPeriodo(inicio, fin);
            string[] labelsYDataCategorias = MapaAStrings(totalPorCategoria, c => c.Nombre);


            Dictionary<Cliente, double> totalPorCliente = Papeleria.Instancia.Ventas.ListarIngresosPorClienteEnPeriodo(inicio, fin);
            string[] labelsYDataClientes = MapaAStrings(totalPorCliente, c => c.Nombre);

            SortedDictionary<DateTime, double> totalPorFecha = Papeleria.Instancia.Ventas.ListarIngresosAgrupadosPorFechaEnPeriodo(inicio, fin);
            string[] labelsYDataFechas = MapaAStrings(totalPorFecha, d => d.ToString("dd/MM/yyyy"));

            string filasTabla = "";

            double totalVentas = 0;

            foreach (Venta venta in ventas)
            {
                totalVentas += venta.Total;
                filasTabla += "<tr>";
                filasTabla += $"<td>{venta.Fecha.ToString("dd/MM/yyyy")}</td>";
                filasTabla += $"<td>{venta.NroVenta}</td>";
                filasTabla += $"<td>{venta.Cliente.Nombre}</td>";
                filasTabla += $"<td>{venta.ResumenItems}</td>";
                filasTabla += $"<td>${venta.Total.ToString("N")}</td>";
                filasTabla += "</tr>";
            }

            plantillaHtml = plantillaHtml.Replace("@GRAFICO_CATEGORIAS_LABELS", labelsYDataCategorias[0]);
            plantillaHtml = plantillaHtml.Replace("@GRAFICO_CATEGORIAS_DATA", labelsYDataCategorias[1]);
            plantillaHtml = plantillaHtml.Replace("@GRAFICO_CLIENTES_LABELS", labelsYDataClientes[0]);
            plantillaHtml = plantillaHtml.Replace("@GRAFICO_CLIENTES_DATA", labelsYDataClientes[1]);
            plantillaHtml = plantillaHtml.Replace("@GRAFICO_FECHAS_LABELS", labelsYDataFechas[0]);
            plantillaHtml = plantillaHtml.Replace("@GRAFICO_FECHAS_DATA", labelsYDataFechas[1]);
            plantillaHtml = plantillaHtml.Replace("@FILAS", filasTabla);
            plantillaHtml = plantillaHtml.Replace("@TOTAL", $"${totalVentas.ToString("N")}");

            plantillaHtml = plantillaHtml.Replace("@NRO_VENTAS", ventas.Count.ToString());


            this.datos = plantillaHtml;
        }
        private static string[] MapaAStrings<T>(IDictionary<T, double> dict, Func<T, string> func)
        {
            string a = "";
            string b = "";
            if (dict.Count == 0) return new string[] { a, b };
            foreach (var entry in dict)
            {
                a += $"'{func.Invoke(entry.Key)}',";
                b += $"{entry.Value},";
            }
            a = a.Substring(0, a.Length - 1);
            b = b.Substring(0, b.Length - 1);
            return new string[] { a, b };

        }

    }

}
