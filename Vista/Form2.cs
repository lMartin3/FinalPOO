﻿using Entidades;
using NuevoModelo;
using System.Data;
using Controladoras;

namespace PapeleriaGUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ActualizarGrids();
        }

        private void ActualizarGrids()
        {
            gridVentas.DataSource = Papeleria.Instancia.Ventas.ListarVentas()
                .Select(venta =>
                new
                {
                    CodigoVenta = venta.NroVenta,
                    Cliente = venta.Cliente,
                    Items = venta.ResumenItems,
                    Nroitems = venta.Items.Count,
                    Total = venta.Total
                }).ToList();
            gridClientes.DataSource = Papeleria.Instancia.Clientes.ListarClientes();
            gridOrdenes.DataSource = Papeleria.Instancia.Ordenes.ListarOrdenes()
                .Select(orden =>
                new {
                    NroOrden = orden.NroOrden,
                    Proveedor = orden.Proveedor,
                    Items = orden.ResumenItems,
                    Nroitems = orden.Items.Count,
                    Total = orden.Total
                }).ToList();
            gridProveedores.DataSource = Papeleria.Instancia.Proveedores.ListarProveedores();
            gridProductos.DataSource = Papeleria.Instancia.Productos.ListarProductos();
            gridCategorias.DataSource = Papeleria.Instancia.Categorias.ListarCategorias();
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            FormCreacionVenta form1 = new FormCreacionVenta();
            form1.ShowDialog();
            ActualizarGrids();
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            if (gridVentas.CurrentRow == null) return;
            Venta venta = Papeleria.Instancia.Ventas.ListarVentas().ElementAt(gridVentas.CurrentRow.Index);
            //Papeleria.Instancia.Ventas.EliminarVenta(venta);
            ActualizarGrids();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FormCreacionCliente formCreacionCliente = new FormCreacionCliente();
            formCreacionCliente.ShowDialog();
            ActualizarGrids();
        }
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (gridClientes.CurrentRow == null) return;
            Cliente cliente = Papeleria.Instancia.Clientes.ListarClientes().ElementAt(gridClientes.CurrentRow.Index);
            Papeleria.Instancia.Clientes.EliminarCliente(cliente); //Checkear que esto funque bien
            ActualizarGrids();
        }

        private void btnAgregarOrden_Click(object sender, EventArgs e)
        {
            FormCreacionOrden formCreacionOrden = new FormCreacionOrden();
            formCreacionOrden.ShowDialog();
            ActualizarGrids();
        }

        private void btnEliminarOrden_Click(object sender, EventArgs e)
        {
            if (gridOrdenes.CurrentRow == null) return;
            OrdenCompra orden = Papeleria.Instancia.Ordenes.ListarOrdenes().ElementAt(gridOrdenes.CurrentRow.Index);
            //Papeleria.Instancia.Ordenes.EliminarOrden(orden);
            ActualizarGrids();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            FormCreacionProveedor formCreacionProveedor = new FormCreacionProveedor();
            formCreacionProveedor.ShowDialog();
            ActualizarGrids();
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (gridProveedores.CurrentRow == null) return;
            Proveedor proveedor = Papeleria.Instancia.Proveedores.ListarProveedores().ElementAt(gridProveedores.CurrentRow.Index);
            //Papeleria.Instancia.Proveedores.EliminarProveedor(proveedor);
            ActualizarGrids();
        }

        private void btnDetallesOrden_Click(object sender, EventArgs e)
        {
            if (gridOrdenes.CurrentRow == null) return;
            OrdenCompra orden = Papeleria.Instancia.Ordenes.ListarOrdenes().ElementAt(gridOrdenes.CurrentRow.Index);
            if (orden == null) return;
            FormDetalles formDetalles = new FormDetalles("Detalles de Orden de Compra", orden.Items);
            formDetalles.ShowDialog();
        }

        private void buttonDetallesVenta_Click(object sender, EventArgs e)
        {
            if (gridVentas.CurrentRow == null) return;
            Venta venta = Papeleria.Instancia.Ventas.ListarVentas().ElementAt(gridVentas.CurrentRow.Index);
            if (venta == null) return;
            FormDetalles formDetalles = new FormDetalles("Detalles de Ventas", venta.Items);
            formDetalles.ShowDialog();
        }
    }


}
