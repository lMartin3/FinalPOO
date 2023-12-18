using Controladoras;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.Reportes
{
    internal class GeneradorReporteItemsVentasCSV : GeneradorReportes
    {
        public override string Extension { get => "csv"; }


        public override void CargarDatos(DateTime inicio, DateTime fin)
        {
            string resultado = "" +
                "Fecha;" +
                "NroVenta;" +
                "NombreCliente;" +
                "DocumentoCliente;" +
                "CodProducto;" +
                "NombreProducto;" +
                "Cantidad;" +
                "PrecioUnitario;" +
                "Subtotal";
            IReadOnlyCollection<Venta> ventas = Papeleria.Instancia.Ventas.ListarVentasEnPeriodo(inicio, fin);
            foreach(Venta venta in ventas)
            {
                foreach(ItemProducto item in venta.Items)
                {

                    resultado += $"\n" +
                        $"{venta.Fecha.ToString("dd/MM/yyyy")};" +
                        $"{venta.NroVenta};{venta.Cliente.Nombre};" +
                        $"{venta.Cliente.DniOCuit};" +
                        $"{item.Producto.Codigo};" +
                        $"{item.Producto.Nombre};" +
                        $"{item.Cantidad};" +
                        $"{item.PrecioUnitario};" +
                        $"{item.Subtotal}"
                        ;
                }
            }

            this.datos = resultado;

        }
    }
}
