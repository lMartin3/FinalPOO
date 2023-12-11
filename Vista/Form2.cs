using Entidades;
using NuevoModelo;
using System.Data;

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
            gridVentas.DataSource = papeleria.Ventas.ElementosAlmacenados
                .Select(venta =>
                new {
                    CodigoVenta = venta.NroVenta,
                    Cliente = venta.Cliente,
                    Items = venta.ResumenItems,
                    Nroitems = venta.Items.Count,
                    Total = venta.Total
                }).ToList();
            gridClientes.DataSource = papeleria.Clientes.ElementosAlmacenados;
            gridOrdenes.DataSource = papeleria.Ordenes.ElementosAlmacenados
                .Select(orden =>
                new {
                    NroOrden = orden.NroOrden,
                    Proveedor = orden.Proveedor,
                    Items = orden.ResumenItems,
                    Nroitems = orden.Items.Count,
                    Total = orden.Total
                }).ToList();
            gridProveedores.DataSource = papeleria.Proveedores.ElementosAlmacenados;
            gridProductos.DataSource = papeleria.Productos.ElementosAlmacenados;
            gridCategorias.DataSource = papeleria.Categorias.ElementosAlmacenados;
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            FormCreacionVenta form1 = new FormCreacionVenta(papeleria);
            form1.ShowDialog();
            ActualizarGrids();
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            if (gridVentas.CurrentRow == null) return;
            Venta venta = papeleria.Ventas.ElementosAlmacenados.ElementAt(gridVentas.CurrentRow.Index);
            papeleria.Ventas.EliminarElemento(venta);
            ActualizarGrids();
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
            Cliente cliente = papeleria.Clientes.ElementosAlmacenados.ElementAt(gridClientes.CurrentRow.Index);
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
            OrdenCompra orden = papeleria.Ordenes.ElementosAlmacenados.ElementAt(gridOrdenes.CurrentRow.Index);
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
            Proveedor proveedor = papeleria.Proveedores.ElementosAlmacenados.ElementAt(gridProveedores.CurrentRow.Index);
            papeleria.Proveedores.EliminarElemento(proveedor);
            ActualizarGrids();
        }

        private void btnDetallesOrden_Click(object sender, EventArgs e)
        {
            if (gridOrdenes.CurrentRow == null) return;
            OrdenCompra orden = papeleria.Ordenes.ElementosAlmacenados.ElementAt(gridOrdenes.CurrentRow.Index);
            if (orden == null) return;
            FormDetalles formDetalles = new FormDetalles("Detalles de Orden de Compra", orden.Items);
            formDetalles.ShowDialog();
        }

        private void buttonDetallesVenta_Click(object sender, EventArgs e)
        {
            if (gridVentas.CurrentRow == null) return;
            Venta venta = papeleria.Ventas.ElementosAlmacenados.ElementAt(gridVentas.CurrentRow.Index);
            if (venta == null) return;
            FormDetalles formDetalles = new FormDetalles("Detalles de Ventas", venta.Items);
            formDetalles.ShowDialog();
        }
    }
}
