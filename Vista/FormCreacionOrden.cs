using Controladoras;
using Entidades;
using Vista.Util;

namespace PapeleriaGUI
{
    public partial class FormCreacionOrden : Form
    {
        private List<ItemProducto> listaItems = new List<ItemProducto>();
        public FormCreacionOrden()
        {
            InitializeComponent();
            ActualizarGrid();
            btnAgregarItem.Enabled = false;
            btnCrearOrden.Enabled = false;
            nCantidadItem.Maximum = decimal.MaxValue;
            foreach(Producto producto in Papeleria.Instancia.Productos.ListarProductos())
            {
                cbProductoItem.Items.Add(producto.Nombre);
            }

            foreach(Proveedor proveedor in Papeleria.Instancia.Proveedores.ListarProveedores())
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
                listaItems.Count > 0;

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
            gridItems.DataSource = listaItems;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            Producto? producto = Papeleria.Instancia.Productos.BuscarPorNombre(cbProductoItem.Text);
            if (producto == null)
            {
                MessageBox.Show("Error al agregar el item del producto seleccionado.");
                return;
            }
            int cantidad = (int) nCantidadItem.Value;
            float precioUnitario;
            float.TryParse(txtPrecioItem.Text,out precioUnitario);

            ItemProducto itemCompra = new ItemProducto(
                producto,
                cantidad,
                precioUnitario
                );

            listaItems.Add(itemCompra);
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
            listaItems.RemoveAt(fila);
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

            ResultadoOperacion res = Papeleria.Instancia.Ordenes.CrearOrdenDeCompra(ordenCompra);
            if (!res.Exito)
            {
                MessageBox.Show(res.Mensaje);
                return;
            }

            Close();

        }

    }
}
