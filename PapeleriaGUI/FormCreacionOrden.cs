using Modelo;
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

namespace PapeleriaGUI
{
    public partial class FormCreacionOrden : Form
    {
        private List<ItemCompra> items;
        private Regex regexNum = new Regex("^[0-9]{1,}$");
        public FormCreacionOrden()
        {
            InitializeComponent();
            gridItems.DataSource = items;
        }

        private void ActualizarBotonItem()
        {
            bool habilitar =
                esNumero(cbProductoItem.Text) &&
                esNumero(txtCantidadItem.Text) &&
                txtNroOrden.Text.Length > 0;

            btnAgregarItem.Enabled = habilitar;
        }

        private bool esNumero(string input)
        {
           return regexNum.IsMatch(input);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {

        }

        private void cbProductoItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarBotonItem();
        }

        private void txtCantidadItem_TextChanged(object sender, EventArgs e)
        {
            ActualizarBotonItem();
        }

        private void txtPrecioItem_TextChanged(object sender, EventArgs e)
        {
            ActualizarBotonItem();
        }
    }
}
