using Entidades;
using NuevoModelo;
using NuevoModelo.Util;

namespace PapeleriaGUI
{
    public partial class FormCreacionOrden : Form
    {
        private Papeleria papeleria;
        private ListaDeItemsProductoOrden listaItems = new ListaDeItemsProductoOrden();
        public FormCreacionOrden(Papeleria papeleria)
        {
            this.papeleria = papeleria;
            InitializeComponent();
            ActualizarGrid();
            btnAgregarItem.Enabled = false;
            btnCrearOrden.Enabled = false;
            nCantidadItem.Maximum = decimal.MaxValue;
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
            btnAgregarItem.Enabled = ValidacionUtil.EsNumeroPositivo(txtPrecioItem.Text) &&
                nCantidadItem.Value > 0 &&
                cbProductoItem.Text.Length > 0;
        }

        private void ActualizarBotonCompra()
        {
            bool habilitar =
                ValidacionUtil.EsNumeroPositivo(txtNroOrden.Text) &&
                cbProveedorOrden.Text.Length > 0 &&
                listaItems.itemsReadonly.Count > 0;

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
            gridItems.DataSource = listaItems.itemsReadonly;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            Producto producto = papeleria.Productos.BuscarPorNombre(cbProductoItem.Text);
            
            int cantidad = (int) nCantidadItem.Value;
            float precioUnitario;
            float.TryParse(txtPrecioItem.Text,out precioUnitario);

            ItemProducto itemCompra = new ItemProducto(
                producto,
                cantidad,
                precioUnitario
                );

            listaItems.AddItem(itemCompra);
            LimpiarCamposItem();
            ActualizarBotonCompra();
            ActualizarGrid();
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
            listaItems.RemoverItemEn(fila);
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
        private void button1_Click(object sender, EventArgs e)
        {
            int nroOrden;
            int.TryParse(txtNroOrden.Text, out nroOrden);
            Proveedor proveedor = (Proveedor)cbProveedorOrden.SelectedItem;

            OrdenCompra ordenCompra = new OrdenCompra(
                nroOrden.ToString(),
                proveedor,
                listaItems
            );

            bool resultado = papeleria.Ordenes.AgregarElemento(ordenCompra);
            if(!resultado)
            {
                MessageBox.Show("Error al cargar la orden de compra!");
                return;
            }

            Close();
        }
    }
}
