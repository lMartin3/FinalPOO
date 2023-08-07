using Modelo;
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
    public partial class Form2 : Form
    {
        private Papeleria papeleria; 
        public Form2(Papeleria papeleria)
        {
            this.papeleria = papeleria;
            InitializeComponent();
            ActualizarGrids();
        }

        private void ActualizarGrids()
        {
            gridVentas.DataSource = papeleria.Ventas.ElementosAlmacenados;
            gridClientes.DataSource = papeleria.Clientes.ElementosAlmacenados;
            gridOrdenes.DataSource = papeleria.Ordenes.ElementosAlmacenados;
            gridProveedores.DataSource = papeleria.Proveedores.ElementosAlmacenados;
            gridProductos.DataSource = papeleria.Productos.ElementosAlmacenados;
            gridCategorias.DataSource = papeleria.Categorias.ElementosAlmacenados;
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            ActualizarGrids();
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FormCreacionCliente formCreacionCliente = new FormCreacionCliente(papeleria);
            formCreacionCliente.ShowDialog();
            ActualizarGrids();
        }
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (gridClientes.CurrentRow == null) return;
            Cliente cliente = gridClientes.CurrentRow.DataBoundItem as Cliente;
            papeleria.Clientes.EliminarElemento(cliente);
            ActualizarGrids();
        }

        private void btnAgregarOrden_Click(object sender, EventArgs e)
        {
            FormCreacionOrden formCreacionOrden = new FormCreacionOrden(papeleria);
            formCreacionOrden.ShowDialog();
            ActualizarGrids();
        }

        private void btnEliminarOrden_Click(object sender, EventArgs e)
        {
            if (gridOrdenes.CurrentRow == null) return;
            OrdenCompra orden = gridOrdenes.CurrentRow.DataBoundItem as OrdenCompra;
            papeleria.Ordenes.EliminarElemento(orden);
            ActualizarGrids();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            FormCreacionProveedor formCreacionProveedor = new FormCreacionProveedor(papeleria);
            formCreacionProveedor.ShowDialog();
            ActualizarGrids();
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (gridProveedores.CurrentRow == null) return;
            Proveedor proveedor = gridProveedores.CurrentRow.DataBoundItem as Proveedor;
            papeleria.Proveedores.EliminarElemento(proveedor);
            ActualizarGrids();
        }

        private void tabProductos_Click(object sender, EventArgs e)
        {

        }
    }
}
