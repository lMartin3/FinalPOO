using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PapeleriaGUI
{
    public partial class FormCreacionCliente : Form
    {
        public FormCreacionCliente()
        {
            InitializeComponent();
            btnAgregar.Enabled = false;
        }

        private void EvaluarCondiciones()
        {
            btnAgregar.Enabled =
                txtDni.Text.Length > 0 &&
                txtNombre.Text.Length > 0 &&
                cbCondicion.Text.Length > 0 &&
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
    }
}
