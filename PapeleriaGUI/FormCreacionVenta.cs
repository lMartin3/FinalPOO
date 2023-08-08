using Modelo;
using Modelo.Dato;
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
    public partial class FormCreacionVenta : Form
    {
        private Papeleria papeleria;
        private ListaDeItemsProductoVenta listaItems = new ListaDeItemsProductoVenta();
        private Regex regexNum = new Regex("^[0-9]{1,}$");
        public FormCreacionVenta(Papeleria papeleria)
        {
            this.papeleria = papeleria;
            InitializeComponent();
            ActualizarGrid();
            btnAgregarItem.Enabled = false;
            btnCrearRegistro.Enabled = false;
            PopularComboBoxes();
        }

        private void PopularComboBoxes()
        {
            cbProductoItem.DataSource = papeleria.Productos.ElementosAlmacenados.ToList();
            cbProductoItem.DisplayMember = "Nombre";
            cbClienteVenta.DataSource = papeleria.Clientes.ElementosAlmacenados.ToList();
            cbClienteVenta.DisplayMember = "Nombre";
        }

        private void ActualizarBotonItem()
        {
            bool habilitar =
                nCantidadItem.Value > 0 &&
                cbProductoItem.SelectedItem != null;

            btnAgregarItem.Enabled = habilitar;
        }

        private void ActualizarBotonVenta()
        {
            bool habilitar =
                ValidacionUtil.EsNumeroPositivo(txtCodigoVenta.Text) &&
                cbClienteVenta.Text.Length > 0 &&
                listaItems.itemsReadonly.Count > 0;

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
            var listaDeDatosNotables = listaItems.itemsReadonly
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

            ItemProducto itemVenta = new ItemProducto(
                
            producto,
            cantidad,
            producto.Precio
                
                );

            if (!listaItems.AddItem(itemVenta))
            {
                MessageBox.Show("No se pudo registrar el item!");
            }
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
            listaItems.RemoverItemEn(fila);
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


            Venta venta = new Venta(
                codVenta,
                ventaDateTimePicker.Value,
                cliente,
                listaItems
                );
            bool resultado = papeleria.Ventas.AgregarElemento(venta);
            if(!resultado)
            {
                MessageBox.Show("Error al registrar la venta!");
                return;
            }

            Close();
        }
        private void ActualizarCantidadElegibleDeProducto()
        {
            Producto productoSeleccionado = (Producto)cbProductoItem.SelectedItem;
            if(productoSeleccionado != null)
            {
                int cantidadDelStockDelProductoUsado = listaItems.ObtenerStockUtilizadoDeProducto(productoSeleccionado);
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
