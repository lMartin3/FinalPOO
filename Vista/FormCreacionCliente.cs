using Controladoras;
using Entidades;
using Vista.Util;

namespace PapeleriaGUI
{
    public partial class FormCreacionCliente : Form
    {
        public FormCreacionCliente()
        {
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

            ResultadoOperacion res = Papeleria.Instancia.Clientes.CrearCliente(cliente);
            if(!res.Exito)
            {
                MessageBox.Show(res.Mensaje);
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
