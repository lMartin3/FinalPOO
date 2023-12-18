namespace PapeleriaGUI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabCategorias = new TabPage();
            gridCategorias = new DataGridView();
            tabProductos = new TabPage();
            gridProductos = new DataGridView();
            tabProveedores = new TabPage();
            btnEliminarProveedor = new Button();
            btnAgregarProveedor = new Button();
            gridProveedores = new DataGridView();
            tabOrdenesDeCompra = new TabPage();
            btnDetallesOrden = new Button();
            btnEliminarOrden = new Button();
            btnAgregarOrden = new Button();
            gridOrdenes = new DataGridView();
            tabClientes = new TabPage();
            btnEliminarCliente = new Button();
            btnAgregarCliente = new Button();
            gridClientes = new DataGridView();
            tabVentas = new TabPage();
            buttonDetallesVenta = new Button();
            btnEliminarVenta = new Button();
            btnAgregarVenta = new Button();
            gridVentas = new DataGridView();
            tabControl = new TabControl();
            tabReportes = new TabPage();
            btnAlerta = new Button();
            btnGenerarReporteVentas = new Button();
            tabCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCategorias).BeginInit();
            tabProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridProductos).BeginInit();
            tabProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridProveedores).BeginInit();
            tabOrdenesDeCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridOrdenes).BeginInit();
            tabClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridClientes).BeginInit();
            tabVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridVentas).BeginInit();
            tabControl.SuspendLayout();
            tabReportes.SuspendLayout();
            SuspendLayout();
            // 
            // tabCategorias
            // 
            tabCategorias.Controls.Add(gridCategorias);
            tabCategorias.Location = new Point(4, 24);
            tabCategorias.Margin = new Padding(4, 3, 4, 3);
            tabCategorias.Name = "tabCategorias";
            tabCategorias.Padding = new Padding(4, 3, 4, 3);
            tabCategorias.Size = new Size(1158, 638);
            tabCategorias.TabIndex = 5;
            tabCategorias.Text = "Categorías de Producto";
            tabCategorias.UseVisualStyleBackColor = true;
            // 
            // gridCategorias
            // 
            gridCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCategorias.Location = new Point(7, 7);
            gridCategorias.Margin = new Padding(4, 3, 4, 3);
            gridCategorias.Name = "gridCategorias";
            gridCategorias.Size = new Size(1142, 622);
            gridCategorias.TabIndex = 9;
            // 
            // tabProductos
            // 
            tabProductos.Controls.Add(gridProductos);
            tabProductos.Location = new Point(4, 24);
            tabProductos.Margin = new Padding(4, 3, 4, 3);
            tabProductos.Name = "tabProductos";
            tabProductos.Padding = new Padding(4, 3, 4, 3);
            tabProductos.Size = new Size(1158, 638);
            tabProductos.TabIndex = 4;
            tabProductos.Text = "Productos";
            tabProductos.UseVisualStyleBackColor = true;
            // 
            // gridProductos
            // 
            gridProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProductos.Location = new Point(7, 7);
            gridProductos.Margin = new Padding(4, 3, 4, 3);
            gridProductos.Name = "gridProductos";
            gridProductos.Size = new Size(1142, 622);
            gridProductos.TabIndex = 6;
            // 
            // tabProveedores
            // 
            tabProveedores.Controls.Add(btnEliminarProveedor);
            tabProveedores.Controls.Add(btnAgregarProveedor);
            tabProveedores.Controls.Add(gridProveedores);
            tabProveedores.Location = new Point(4, 24);
            tabProveedores.Margin = new Padding(4, 3, 4, 3);
            tabProveedores.Name = "tabProveedores";
            tabProveedores.Padding = new Padding(4, 3, 4, 3);
            tabProveedores.Size = new Size(1158, 638);
            tabProveedores.TabIndex = 3;
            tabProveedores.Text = "Proveedores";
            tabProveedores.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProveedor
            // 
            btnEliminarProveedor.Location = new Point(850, 81);
            btnEliminarProveedor.Margin = new Padding(4, 3, 4, 3);
            btnEliminarProveedor.Name = "btnEliminarProveedor";
            btnEliminarProveedor.Size = new Size(284, 28);
            btnEliminarProveedor.TabIndex = 5;
            btnEliminarProveedor.Text = "Eliminar Proveedor seleccionado";
            btnEliminarProveedor.UseVisualStyleBackColor = true;
            btnEliminarProveedor.Click += btnEliminarProveedor_Click;
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.Location = new Point(850, 32);
            btnAgregarProveedor.Margin = new Padding(4, 3, 4, 3);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(284, 28);
            btnAgregarProveedor.TabIndex = 4;
            btnAgregarProveedor.Text = "Agregar nuevo Proveedor";
            btnAgregarProveedor.UseVisualStyleBackColor = true;
            btnAgregarProveedor.Click += btnAgregarProveedor_Click;
            // 
            // gridProveedores
            // 
            gridProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProveedores.Location = new Point(7, 7);
            gridProveedores.Margin = new Padding(4, 3, 4, 3);
            gridProveedores.Name = "gridProveedores";
            gridProveedores.Size = new Size(808, 622);
            gridProveedores.TabIndex = 3;
            // 
            // tabOrdenesDeCompra
            // 
            tabOrdenesDeCompra.Controls.Add(btnDetallesOrden);
            tabOrdenesDeCompra.Controls.Add(btnEliminarOrden);
            tabOrdenesDeCompra.Controls.Add(btnAgregarOrden);
            tabOrdenesDeCompra.Controls.Add(gridOrdenes);
            tabOrdenesDeCompra.Location = new Point(4, 24);
            tabOrdenesDeCompra.Margin = new Padding(4, 3, 4, 3);
            tabOrdenesDeCompra.Name = "tabOrdenesDeCompra";
            tabOrdenesDeCompra.Padding = new Padding(4, 3, 4, 3);
            tabOrdenesDeCompra.Size = new Size(1158, 638);
            tabOrdenesDeCompra.TabIndex = 2;
            tabOrdenesDeCompra.Text = "Órdenes de compra";
            tabOrdenesDeCompra.UseVisualStyleBackColor = true;
            // 
            // btnDetallesOrden
            // 
            btnDetallesOrden.Location = new Point(850, 132);
            btnDetallesOrden.Margin = new Padding(4, 3, 4, 3);
            btnDetallesOrden.Name = "btnDetallesOrden";
            btnDetallesOrden.Size = new Size(284, 28);
            btnDetallesOrden.TabIndex = 6;
            btnDetallesOrden.Text = "Ver detalles de la Orden";
            btnDetallesOrden.UseVisualStyleBackColor = true;
            btnDetallesOrden.Click += btnDetallesOrden_Click;
            // 
            // btnEliminarOrden
            // 
            btnEliminarOrden.Location = new Point(850, 81);
            btnEliminarOrden.Margin = new Padding(4, 3, 4, 3);
            btnEliminarOrden.Name = "btnEliminarOrden";
            btnEliminarOrden.Size = new Size(284, 28);
            btnEliminarOrden.TabIndex = 5;
            btnEliminarOrden.Text = "Eliminar Orden de Compra seleccionada";
            btnEliminarOrden.UseVisualStyleBackColor = true;
            btnEliminarOrden.Click += btnEliminarOrden_Click;
            // 
            // btnAgregarOrden
            // 
            btnAgregarOrden.Location = new Point(850, 32);
            btnAgregarOrden.Margin = new Padding(4, 3, 4, 3);
            btnAgregarOrden.Name = "btnAgregarOrden";
            btnAgregarOrden.Size = new Size(284, 28);
            btnAgregarOrden.TabIndex = 4;
            btnAgregarOrden.Text = "Agregar nueva Orden de Compra";
            btnAgregarOrden.UseVisualStyleBackColor = true;
            btnAgregarOrden.Click += btnAgregarOrden_Click;
            // 
            // gridOrdenes
            // 
            gridOrdenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridOrdenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridOrdenes.Location = new Point(7, 7);
            gridOrdenes.Margin = new Padding(4, 3, 4, 3);
            gridOrdenes.Name = "gridOrdenes";
            gridOrdenes.Size = new Size(808, 622);
            gridOrdenes.TabIndex = 3;
            // 
            // tabClientes
            // 
            tabClientes.Controls.Add(btnEliminarCliente);
            tabClientes.Controls.Add(btnAgregarCliente);
            tabClientes.Controls.Add(gridClientes);
            tabClientes.Location = new Point(4, 24);
            tabClientes.Margin = new Padding(4, 3, 4, 3);
            tabClientes.Name = "tabClientes";
            tabClientes.Padding = new Padding(4, 3, 4, 3);
            tabClientes.Size = new Size(1158, 638);
            tabClientes.TabIndex = 1;
            tabClientes.Text = "Clientes";
            tabClientes.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(850, 81);
            btnEliminarCliente.Margin = new Padding(4, 3, 4, 3);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(284, 28);
            btnEliminarCliente.TabIndex = 5;
            btnEliminarCliente.Text = "Eliminar Cliente seleccionado";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(850, 32);
            btnAgregarCliente.Margin = new Padding(4, 3, 4, 3);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(284, 28);
            btnAgregarCliente.TabIndex = 4;
            btnAgregarCliente.Text = "Agregar nuevo Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // gridClientes
            // 
            gridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClientes.Location = new Point(7, 7);
            gridClientes.Margin = new Padding(4, 3, 4, 3);
            gridClientes.Name = "gridClientes";
            gridClientes.Size = new Size(808, 622);
            gridClientes.TabIndex = 3;
            // 
            // tabVentas
            // 
            tabVentas.Controls.Add(btnGenerarReporteVentas);
            tabVentas.Controls.Add(buttonDetallesVenta);
            tabVentas.Controls.Add(btnEliminarVenta);
            tabVentas.Controls.Add(btnAgregarVenta);
            tabVentas.Controls.Add(gridVentas);
            tabVentas.Location = new Point(4, 24);
            tabVentas.Margin = new Padding(4, 3, 4, 3);
            tabVentas.Name = "tabVentas";
            tabVentas.Padding = new Padding(4, 3, 4, 3);
            tabVentas.Size = new Size(1158, 638);
            tabVentas.TabIndex = 0;
            tabVentas.Text = "Ventas";
            tabVentas.UseVisualStyleBackColor = true;
            // 
            // buttonDetallesVenta
            // 
            buttonDetallesVenta.Location = new Point(850, 129);
            buttonDetallesVenta.Margin = new Padding(4, 3, 4, 3);
            buttonDetallesVenta.Name = "buttonDetallesVenta";
            buttonDetallesVenta.Size = new Size(284, 28);
            buttonDetallesVenta.TabIndex = 7;
            buttonDetallesVenta.Text = "Ver detalles de la Venta";
            buttonDetallesVenta.UseVisualStyleBackColor = true;
            buttonDetallesVenta.Click += buttonDetallesVenta_Click;
            // 
            // btnEliminarVenta
            // 
            btnEliminarVenta.Location = new Point(850, 81);
            btnEliminarVenta.Margin = new Padding(4, 3, 4, 3);
            btnEliminarVenta.Name = "btnEliminarVenta";
            btnEliminarVenta.Size = new Size(284, 28);
            btnEliminarVenta.TabIndex = 2;
            btnEliminarVenta.Text = "Eliminar Venta";
            btnEliminarVenta.UseVisualStyleBackColor = true;
            btnEliminarVenta.Click += btnEliminarVenta_Click;
            // 
            // btnAgregarVenta
            // 
            btnAgregarVenta.Location = new Point(850, 32);
            btnAgregarVenta.Margin = new Padding(4, 3, 4, 3);
            btnAgregarVenta.Name = "btnAgregarVenta";
            btnAgregarVenta.Size = new Size(284, 28);
            btnAgregarVenta.TabIndex = 1;
            btnAgregarVenta.Text = "Agregar Venta";
            btnAgregarVenta.UseVisualStyleBackColor = true;
            btnAgregarVenta.Click += btnAgregarVenta_Click;
            // 
            // gridVentas
            // 
            gridVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridVentas.Location = new Point(7, 7);
            gridVentas.Margin = new Padding(4, 3, 4, 3);
            gridVentas.Name = "gridVentas";
            gridVentas.Size = new Size(808, 622);
            gridVentas.TabIndex = 0;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabVentas);
            tabControl.Controls.Add(tabClientes);
            tabControl.Controls.Add(tabOrdenesDeCompra);
            tabControl.Controls.Add(tabProveedores);
            tabControl.Controls.Add(tabProductos);
            tabControl.Controls.Add(tabCategorias);
            tabControl.Controls.Add(tabReportes);
            tabControl.Location = new Point(14, 14);
            tabControl.Margin = new Padding(4, 3, 4, 3);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1166, 666);
            tabControl.TabIndex = 0;
            // 
            // tabReportes
            // 
            tabReportes.Controls.Add(btnAlerta);
            tabReportes.Location = new Point(4, 24);
            tabReportes.Name = "tabReportes";
            tabReportes.Padding = new Padding(3);
            tabReportes.Size = new Size(1158, 638);
            tabReportes.TabIndex = 6;
            tabReportes.Text = "Reportes";
            tabReportes.UseVisualStyleBackColor = true;
            // 
            // btnAlerta
            // 
            btnAlerta.Location = new Point(1048, 41);
            btnAlerta.Name = "btnAlerta";
            btnAlerta.Size = new Size(75, 23);
            btnAlerta.TabIndex = 0;
            btnAlerta.Text = "Test alerat";
            btnAlerta.UseVisualStyleBackColor = true;
            btnAlerta.Click += btnAlerta_Click;
            // 
            // btnGenerarReporteVentas
            // 
            btnGenerarReporteVentas.Location = new Point(850, 181);
            btnGenerarReporteVentas.Margin = new Padding(4, 3, 4, 3);
            btnGenerarReporteVentas.Name = "btnGenerarReporteVentas";
            btnGenerarReporteVentas.Size = new Size(284, 28);
            btnGenerarReporteVentas.TabIndex = 8;
            btnGenerarReporteVentas.Text = "Generar reporte";
            btnGenerarReporteVentas.UseVisualStyleBackColor = true;
            btnGenerarReporteVentas.Click += btnGenerarReporteVentas_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 693);
            Controls.Add(tabControl);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form2";
            Text = "Papelería";
            tabCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridCategorias).EndInit();
            tabProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridProductos).EndInit();
            tabProveedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridProveedores).EndInit();
            tabOrdenesDeCompra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridOrdenes).EndInit();
            tabClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridClientes).EndInit();
            tabVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridVentas).EndInit();
            tabControl.ResumeLayout(false);
            tabReportes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabCategorias;
        private DataGridView gridCategorias;
        private TabPage tabProductos;
        private DataGridView gridProductos;
        private TabPage tabProveedores;
        private Button btnEliminarProveedor;
        private Button btnAgregarProveedor;
        private DataGridView gridProveedores;
        private TabPage tabOrdenesDeCompra;
        private Button btnDetallesOrden;
        private Button btnEliminarOrden;
        private Button btnAgregarOrden;
        private DataGridView gridOrdenes;
        private TabPage tabClientes;
        private Button btnEliminarCliente;
        private Button btnAgregarCliente;
        private DataGridView gridClientes;
        private TabPage tabVentas;
        private Button buttonDetallesVenta;
        private Button btnEliminarVenta;
        private Button btnAgregarVenta;
        private DataGridView gridVentas;
        private TabControl tabControl;
        private TabPage tabReportes;
        private Button btnAlerta;
        private Button btnGenerarReporteVentas;
    }
}