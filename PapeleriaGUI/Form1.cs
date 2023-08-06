using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PapeleriaGUI
{
    public partial class Form1 : Form
    {
        Papeleria logica;
        Venta currentVenta = new Venta();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logica = new Papeleria();
            PopularComboBoxes();
            RefrescarGridItems();
        }
        private void PopularComboBoxes()
        {
            itemVentaProductoComboBox.DataSource = logica.Productos.ElementosAlmacenados.ToList();
            itemVentaProductoComboBox.DisplayMember = "Nombre";
            clienteComboBox.DataSource = logica.Clientes.ElementosAlmacenados.ToList();
            clienteComboBox.DisplayMember = "Nombre";

        }

        private void IntentarRegistrarVenta()
        {
            Venta ventaFinal = new Venta(
                (int)ventaIDnumericUD.Value,
                ventaDateTimePicker.Value,
                (Cliente)clienteComboBox.SelectedItem,
                currentVenta.itemsReadonly.ToList()
                );
            bool exito = logica.IntentarRegistrarVenta(ventaFinal);
            if (exito)
            {
                currentVenta = new Venta();
                RefrescarGridItems();
            }
            else
            {
                ShowError("Datos de venta inválidos, revise los campos e intente de nuevo");
            }
        }

        private void CrearItemVenta()
        {
            Producto productoSeleccionado = (Producto)itemVentaProductoComboBox.SelectedItem;
            float precioAlMomentoDeLaCompra = productoSeleccionado.Precio;
            //(TODO) no se si sigue convenciones
            ItemVenta item = new ItemVenta(
                productoSeleccionado,
                (int)cantidadNumericUpDown.Value,
                precioAlMomentoDeLaCompra
                );
            bool exito = currentVenta.AddItemVenta(item);
            RefrescarGridItems();

            if (!exito)
            {
                ShowError("Item de venta inválido, revise los campos e intente de nuevo");
            }
        }
        private void ShowError(string errorMessage)
        {
            //Podemos mostrar una ventanita o poner una
            //label en rojo que se vaya despues de un delay no se
        }
        private void anadirItemDeVentaButton_Click(object sender, EventArgs e)
        {
            CrearItemVenta();
            ActualizarCantidadElegibleDeProducto();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegistrarVenta_Click(object sender, EventArgs e)
        {
            IntentarRegistrarVenta();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void borrarTodosButton_Click(object sender, EventArgs e)
        {
            currentVenta.LimpiarItems();
            RefrescarGridItems();
        }

        private void RefrescarGridItems()
        {
            var listaDeDatosNotables = currentVenta.itemsReadonly
                .Select(item => new
                {
                    Producto = item.Producto.Nombre,
                    Cantidad = item.Cantidad,
                    PrecioUnitario = item.Producto.Precio,
                    PrecioTotal = item.Cantidad * item.PrecioUnitario
                }
                ).ToList();
            itemsVentaDataGridView.DataSource = listaDeDatosNotables;
        }
        private void ActualizarCantidadElegibleDeProducto()
        {
            Producto productoSeleccionado = (Producto)itemVentaProductoComboBox.SelectedItem;
            int cantidadDelStockDelProductoUsado = currentVenta.ObtenerStockUtilizadoDeProducto(productoSeleccionado);
            cantidadNumericUpDown.Maximum = productoSeleccionado.Stock - cantidadDelStockDelProductoUsado;
        }
        private void itemVentaProductoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarCantidadElegibleDeProducto();
        }

        private void borrarItemSeleccionadoButton_Click(object sender, EventArgs e)
        {
            int indiceRowSeleccionada = itemsVentaDataGridView.SelectedCells[0].RowIndex;
            ItemVenta itemSeleccionado = currentVenta.itemsReadonly[indiceRowSeleccionada];
            Console.WriteLine(itemSeleccionado.Producto.Nombre);
            currentVenta.EliminarItem(itemSeleccionado);
            RefrescarGridItems();
            ActualizarCantidadElegibleDeProducto();
        }
    }
}
