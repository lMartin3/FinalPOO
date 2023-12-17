using Controladoras;
using Entidades;
using System.Data;
using Util;

namespace PapeleriaGUI
{
    public partial class FormCreacionVenta : Form
    {
        private List<ItemProducto> listaItems = new List<ItemProducto>();
        public FormCreacionVenta()
        {
            InitializeComponent();
            ActualizarGrid();
            btnAgregarItem.Enabled = false;
            btnCrearRegistro.Enabled = false;
            PopularComboBoxes();
        }

        private void PopularComboBoxes()
        {
            cbProductoItem.DataSource = Papeleria.Instancia.Productos.ListarProductos();
            cbProductoItem.DisplayMember = "Nombre";
            cbClienteVenta.DataSource = Papeleria.Instancia.Clientes.ListarClientes();
            cbClienteVenta.DisplayMember = "Nombre";
        }

        private void ActualizarBotonItem()
        {
            btnAgregarItem.Enabled = nCantidadItem.Value > 0 &&
                cbProductoItem.SelectedItem != null;
        }

        private void ActualizarBotonVenta()
        {
            bool habilitar =
                ValidacionUtil.EsNumeroPositivo(txtCodigoVenta.Text) &&
                cbClienteVenta.Text.Length > 0 &&
                listaItems.Count > 0;

            btnCrearRegistro.Enabled = habilitar;
        }

        private void LimpiarCamposItem()
        {
            nCantidadItem.Value = 0;
            cbProductoItem.SelectedIndex = -1;
            ActualizarGrid();
        }

        private void ActualizarGrid()
        {
            var listaDeDatosNotables = listaItems
                .Select(item => new
                {
                    Producto = item.Producto.Nombre,
                    Cantidad = item.Cantidad,
                    PrecioUnitario = item.Producto.Precio,
                    Subtotal = item.Subtotal
                }
                ).ToList();
            gridItems.DataSource = listaDeDatosNotables;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            Producto producto = (Producto)cbProductoItem.SelectedItem;
            
            int cantidad = (int) nCantidadItem.Value;

            ItemProducto itemVenta = new ItemProducto(producto,
                cantidad,
                producto.Precio);

            listaItems.Add(itemVenta);
            LimpiarCamposItem();
            ActualizarBotonVenta();
        }

        private void cbProductoItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarCantidadElegibleDeProducto();
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
            ActualizarBotonVenta();
        }

        private void cbProveedorOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarBotonVenta();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int codVenta;
            int.TryParse(txtCodigoVenta.Text, out codVenta);
            Cliente cliente = (Cliente)cbClienteVenta.SelectedItem;


            Venta venta = new Venta(codVenta,
                ventaDateTimePicker.Value,
                cliente,
                listaItems);

            ResultadoOperacion resultado = Papeleria.Instancia.Ventas.CrearVenta(venta);
            if(!resultado.Exito)
            {
                MessageBox.Show(resultado.Mensaje);
                return;
            }

            Close();
        }
        private void ActualizarCantidadElegibleDeProducto()
        {
            Producto productoSeleccionado = (Producto)cbProductoItem.SelectedItem;
            if(productoSeleccionado != null)
            {
                int cantidadDelStockDelProductoUsado = Papeleria.Instancia.Productos.BuscarStockPorCodigo(productoSeleccionado.Codigo);
                nCantidadItem.Maximum = productoSeleccionado.Stock - cantidadDelStockDelProductoUsado;
                return;
            }
            nCantidadItem.Maximum = int.MaxValue;
        }

        private void FormCreacionVenta_Load(object sender, EventArgs e)
        {

        }
    }
}
