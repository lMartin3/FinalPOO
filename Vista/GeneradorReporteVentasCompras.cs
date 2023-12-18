using Controladoras;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista
{
    public class GeneradorReporteVentasCompras
    {

        public static string GenerarReporteVentas(DateTime inicio, DateTime fin)
        {
            if (inicio > fin) return "";

            IReadOnlyCollection<Venta> ventas = Papeleria.Instancia.Ventas.ListarVentasEnPeriodo(inicio, fin); ;
            if (ventas.Count == 0) return "";

            string plantillaHtml = Vista.Properties.Resources.Plantilla;

            plantillaHtml = plantillaHtml.Replace("@DESDE", inicio.ToString("dd/MM/yyyy"));
            plantillaHtml = plantillaHtml.Replace("@HASTA", fin.ToString("dd/MM/yyyy"));

            Dictionary<CategoriaProducto, double> totalPorCategoria = Papeleria.Instancia.Ventas.ListarIngresosPorCategoriaEnPeriodo(inicio, fin);
            string[] labelsYDataCategorias = MapaAStrings(totalPorCategoria, (c => c.Nombre));
            

            Dictionary<Cliente, double> totalPorCliente = Papeleria.Instancia.Ventas.ListarIngresosPorClienteEnPeriodo(inicio, fin);
            string[] labelsYDataClientes = MapaAStrings(totalPorCliente, (c => c.Nombre));

            SortedDictionary<DateTime, double> totalPorFecha = Papeleria.Instancia.Ventas.ListarIngresosAgrupadosPorFechaEnPeriodo(inicio, fin);
            string dataFechas = "";
            foreach (var entry in totalPorFecha)
            {
                dataFechas += $"{entry.Value},";
            }
            dataFechas = dataFechas.Substring(0, dataFechas.Length - 1);
            string labelsFechas = "";
            for(int  i = 0; i+5<totalPorFecha.Count; i+=5)
            {
                    labelsFechas += $"'{totalPorFecha.ElementAt(i).Key.ToString("dd/MM/yyyy")}',";
            }

            plantillaHtml = plantillaHtml.Replace("@GRAFICO_CATEGORIAS_LABELS", labelsYDataCategorias[0]);
            plantillaHtml = plantillaHtml.Replace("@GRAFICO_CATEGORIAS_DATA", labelsYDataCategorias[1]);
            plantillaHtml = plantillaHtml.Replace("@GRAFICO_CLIENTES_LABELS", labelsYDataClientes[0]);
            plantillaHtml = plantillaHtml.Replace("@GRAFICO_CLIENTES_DATA", labelsYDataClientes[1]);
            plantillaHtml = plantillaHtml.Replace("@GRAFICO_FECHAS_LABELS", labelsFechas);
            plantillaHtml = plantillaHtml.Replace("@GRAFICO_FECHAS_DATA", dataFechas);

            plantillaHtml = plantillaHtml.Replace("@NRO_VENTAS", ventas.Count.ToString());


            return plantillaHtml;
        }
        private static string[] MapaAStrings<T>(Dictionary<T, double> dict, Func<T, string> func) {
            string a = "";
            string b = "";
            if(dict.Count==0) return new string[]{ a, b };
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
