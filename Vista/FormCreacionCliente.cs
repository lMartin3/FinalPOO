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
            btnAgregar.Enabled = ValidacionUtil.EsDniOCuitValido(txtDni.Text) &&
                txtNombre.Text.Length > 0 &&
                cbCondicion.Text.Length > 0 &&
                CondicionFiscalUtil.CondicionPorString(cbCondicion.Text).HasValue &&
                txtDireccion.Text.Length > 0;
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
            Cliente cliente = new Cliente(txtDni.Text,
                    CondicionFiscalUtil.CondicionPorString(cbCondicion.Text).Value,
                    txtNombre.Text,
                    txtDireccion.Text);

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
    }
}
