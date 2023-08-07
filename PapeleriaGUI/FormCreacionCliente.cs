using Modelo;
using Modelo.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PapeleriaGUI
{
    public partial class FormCreacionCliente : Form
    {

        private Papeleria papeleria;
        private Regex dniCuitRegex = new Regex("^([0-9]{8}|[0-9]{11})$");
        public FormCreacionCliente(Papeleria papeleria)
        {
            this.papeleria = papeleria; 
            InitializeComponent();
            btnAgregar.Enabled = false;
            cbCondicion.Items.Clear();

            foreach (String cf in CondicionFiscalUtil.CondicionesComoStrings())
            {
                cbCondicion.Items.Add(cf);
            }
        }

        private void EvaluarCondiciones()
        {
            bool camposOK = 
                txtDni.Text.Length > 0 &&
                DniOCuitValido() &&
                txtNombre.Text.Length > 0 &&
                cbCondicion.Text.Length > 0 &&
                CondicionFiscalUtil.CondicionPorString(cbCondicion.Text).HasValue &&
                txtDireccion.Text.Length > 0;
            btnAgregar.Enabled = camposOK;
        }

        private Boolean DniOCuitValido()
        {
            return dniCuitRegex.IsMatch(txtDni.Text);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            EvaluarCondiciones();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            EvaluarCondiciones();
        }

        private void cbCondicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            EvaluarCondiciones();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            EvaluarCondiciones();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Dni = txtDni.Text;
            cliente.CondicionFiscal = CondicionFiscalUtil.CondicionPorString(cbCondicion.Text).Value;
            cliente.Direccion = txtDireccion.Text;

            bool exito = papeleria.Clientes.AgregarElemento(cliente);
            if(!exito)
            {
                MessageBox.Show("Error al registrar el cliente!");
                return;
            }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCreacionCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
