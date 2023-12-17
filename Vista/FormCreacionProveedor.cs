using Controladoras;
using Entidades;
using Vista.Util;


namespace PapeleriaGUI
{
    public partial class FormCreacionProveedor : Form
    {
        public FormCreacionProveedor()
        {
            InitializeComponent();
            btnAgregar.Enabled = false;
            cbCondicion.Items.Clear();
            foreach (String cf in CondicionFiscalUtil.CondicionesComoStrings())
            {
                cbCondicion.Items.Add(cf);
            }
        }

        private void ActualizarBotonAgregar()
        {
            btnAgregar.Enabled = ValidacionUtil.EsCuitValido(txtCuit.Text) &&
                txtRazon.Text.Length > 0 &&
                txtDireccion.Text.Length > 0 &&
                cbCondicion.Text.Length > 0;

        }

        private void txtCuit_TextChanged(object sender, EventArgs e)
        {
            ActualizarBotonAgregar();
        }

        private void txtRazon_TextChanged(object sender, EventArgs e)
        {
            ActualizarBotonAgregar();
        }

        private void cbCondicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarBotonAgregar();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            ActualizarBotonAgregar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor(
                txtCuit.Text,
                CondicionFiscalUtil.CondicionPorString(cbCondicion.Text).Value,
                txtRazon.Text,
                txtDireccion.Text
            );

            ResultadoOperacion res = Papeleria.Instancia.Proveedores.CrearProveedor(proveedor);
            if (!res.Exito)
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
