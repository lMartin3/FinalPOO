using Controladoras;
using Entidades;
using iText.Html2pdf;
using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.Reportes
{
    internal class GeneradorReporteVentasPDF : GeneradorReporteVentasHTML
    {
        public override string Extension { get => "pdf"; }


        public override bool Guardar(string path)
        {
            using (PdfWriter writer = new PdfWriter(path))
            {
                //ConverterProperties converter = new ConverterProperties();
                HtmlConverter.ConvertToPdf(datos, writer);
            }
            return true;
        }
    }
}
