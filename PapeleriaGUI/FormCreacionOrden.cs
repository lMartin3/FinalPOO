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
        private Papeleria papeleria;
        private List<ItemCompra> items = new List<ItemCompra>();
        private Regex regexNum = new Regex("^[0-9]{1,}$");
        public FormCreacionOrden(Papeleria papeleria)
        {
            this.papeleria = papeleria;
            InitializeComponent();
            items.Add(new ItemCompra());
            gridItems.DataSource = items;
            btnAgregarItem.Enabled = false;
            foreach(Producto producto in papeleria.Productos.ElementosAlmacenados)
            {
                cbProductoItem.Items.Add(producto.Nombre);
            }

            foreach(Proveedor proveedor in papeleria.Proveedores.ElementosAlmacenados)
            {
                cbProveedorOrden.Items.Add(proveedor);
            }
        }

        private void ActualizarBotonItem()
        {
            bool habilitar =
                esNumeroPositivo(txtPrecioItem.Text) &&
                nCantidadItem.Value > 0 &&
                cbProductoItem.Text.Length > 0;

            btnAgregarItem.Enabled = habilitar;
        }

        private void ActualizarBotonCompra()
        {
            bool habilitar =
                esNumeroPositivo(txtNroOrden.Text) &&
                cbProveedorOrden.Text.Length > 0;

            btnCrearOrden.Enabled = habilitar;
        }

        private void LimpiarCamposItem()
        {
            txtPrecioItem.Text = "";
            nCantidadItem.Value = 0;
            cbProductoItem.SelectedIndex = -1;
            ActualizarGrid();
        }

        private void ActualizarGrid()
        {
            gridItems.DataSource = null;
            gridItems.DataSource = items;

        }

        private bool esNumeroPositivo(string input)
        {
            int res = -1;
            int.TryParse(input, out res);
            return res > 0;
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
            ItemCompra itemCompra = new ItemCompra();
            Producto producto = papeleria.Productos.BuscarPorNombre(cbProductoItem.Text);
            
            itemCompra.Producto = producto;
            int cantidad = (int) nCantidadItem.Value;
            float precioUnitario;
            float.TryParse(txtPrecioItem.Text,out precioUnitario);

            itemCompra.Cantidad = cantidad;
            itemCompra.PrecioUnitario = precioUnitario;

            items.Add(itemCompra);
            LimpiarCamposItem();
        }

        private void cbProductoItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarBotonItem();
        }


        private void txtPrecioItem_TextChanged(object sender, EventArgs e)
        {
            ActualizarBotonItem();
        }

        private void nCantidadItem_ValueChanged(object sender, EventArgs e)
        {
            ActualizarBotonItem();
        }

        private void btnEliminarItem_Click(object sender, EventArgs e)
        {
            if (gridItems.CurrentRow == null) return;
            int fila = gridItems.CurrentRow.Index;
            if (fila < 0) return;
            items.RemoveAt(fila);
            ActualizarGrid(); 
        }

        private void txtNroOrden_TextChanged(object sender, EventArgs e)
        {
            ActualizarBotonCompra();
        }

        private void cbProveedorOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarBotonCompra();
        }
    }
}
