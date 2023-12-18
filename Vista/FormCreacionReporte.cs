using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Reportes;

namespace Vista
{
    public partial class FormCreacionReporte : Form
    {
        public FormCreacionReporte()
        {
            InitializeComponent();
        }

        private void FormCreacionReporte_Load(object sender, EventArgs e)
        {
            cbFormato.Items.Clear();
            foreach (FormatoReporte formato in Enum.GetValues(typeof(FormatoReporte)))
            {
                cbFormato.Items.Add(formato);
            }
            cbFormato.SelectedIndex = cbFormato.Items.IndexOf(FormatoReporte.PDF);
        }

        private void btnCrearReporte_Click(object sender, EventArgs e)
        {
            FormatoReporte formato = (FormatoReporte)cbFormato.SelectedItem;
            GeneradorReportes generador;
            switch (formato)
            {
                case FormatoReporte.PDF:
                    generador = new GeneradorReporteVentasPDF();
                    break;
                case FormatoReporte.HTML:
                    generador = new GeneradorReporteVentasHTML();
                    break;
                case FormatoReporte.CSV:
                    generador = new GeneradorReporteVentasCSV();
                    break;
                case FormatoReporte.CSV_ITEMS:
                    generador = new GeneradorReporteItemsVentasCSV();
                    break;
                default:
                    MessageBox.Show("Seleccione un formato válido!");
                    return;
            }
            generador.CargarDatos(calPeriodo.SelectionStart, calPeriodo.SelectionEnd);

            SaveFileDialog dialogoGuardar = new SaveFileDialog();
            dialogoGuardar.FileName = $"{DateTime.Now.ToString("ddMMyyyyHHmmss")}.{generador.Extension}";

            DialogResult resultadoDialogoGuardar = dialogoGuardar.ShowDialog();
            if (resultadoDialogoGuardar != DialogResult.OK)
            {
                MessageBox.Show("Elija un destino válido!");
                return;
            }
            generador.Guardar(dialogoGuardar.FileName);
            if(cbAbrirArchivo.Checked)
            {
                OpenFileWithDefaultProgram(dialogoGuardar.FileName);
            }
            Close();
        }

        private void cbAbrirArchivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        static void OpenFileWithDefaultProgram(string filePath)
        {
            try
            {
                // Use ProcessStartInfo to configure the process
                ProcessStartInfo psi = new ProcessStartInfo(filePath)
                {
                    UseShellExecute = true
                };

                // Start the process
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while opening the file: " + ex.Message);
            }
        }
    }
}
