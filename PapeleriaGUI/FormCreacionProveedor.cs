using Modelo;
using Modelo.Util;
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
    public partial class FormCreacionProveedor : Form
    {
        private Papeleria papeleria;
        public FormCreacionProveedor(Papeleria papeleria)
        {
            InitializeComponent();
            btnAgregar.Enabled = false;
            cbCondicion.Items.Clear();
            foreach (String cf in CondicionFiscalUtil.CondicionesComoStrings())
            {
                cbCondicion.Items.Add(cf);
            }

            this.papeleria = papeleria;
        }

        private void ActualizarBotonAgregar()
        {
            bool habilitar =
                ValidacionUtil.EsCuitValido(txtCuit.Text) &&
                txtRazon.Text.Length>0 &&
                txtDireccion.Text.Length>0 &&
                cbCondicion.Text.Length>0;
            btnAgregar.Enabled = habilitar;

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
            Proveedor proveedor = new Proveedor();
            proveedor.Cuit = txtCuit.Text;
            proveedor.CondicionFiscal = CondicionFiscalUtil.CondicionPorString(cbCondicion.Text).Value;
            proveedor.RazonSocial = txtRazon.Text;
            proveedor.Direccion = txtDireccion.Text;

            bool resultado = papeleria.Proveedores.AgregarElemento(proveedor);
            if(!resultado)
            {
                MessageBox.Show("No se pudo registrar el proveedor!");
                return;
            }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCreacionProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
