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
            btnGenerarReporteVentas = new Button();
            buttonDetallesVenta = new Button();
            btnEliminarVenta = new Button();
            btnAgregarVenta = new Button();
            gridVentas = new DataGridView();
            tabControl = new TabControl();
            tabAlertas = new TabPage();
            lblEmail = new Label();
            tboxEmail = new TextBox();
            btnGuardarEmail = new Button();
            btnAlerta = new Button();
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
            tabAlertas.SuspendLayout();
            SuspendLayout();
            // 
            // tabCategorias
            // 
            tabCategorias.Controls.Add(gridCategorias);
            tabCategorias.Location = new Point(4, 29);
            tabCategorias.Margin = new Padding(5, 4, 5, 4);
            tabCategorias.Name = "tabCategorias";
            tabCategorias.Padding = new Padding(5, 4, 5, 4);
            tabCategorias.Size = new Size(1325, 855);
            tabCategorias.TabIndex = 5;
            tabCategorias.Text = "Categorías de Producto";
            tabCategorias.UseVisualStyleBackColor = true;
            // 
            // gridCategorias
            // 
            gridCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCategorias.Location = new Point(8, 9);
            gridCategorias.Margin = new Padding(5, 4, 5, 4);
            gridCategorias.Name = "gridCategorias";
            gridCategorias.RowHeadersWidth = 51;
            gridCategorias.Size = new Size(1305, 829);
            gridCategorias.TabIndex = 9;
            // 
            // tabProductos
            // 
            tabProductos.Controls.Add(gridProductos);
            tabProductos.Location = new Point(4, 29);
            tabProductos.Margin = new Padding(5, 4, 5, 4);
            tabProductos.Name = "tabProductos";
            tabProductos.Padding = new Padding(5, 4, 5, 4);
            tabProductos.Size = new Size(1325, 855);
            tabProductos.TabIndex = 4;
            tabProductos.Text = "Productos";
            tabProductos.UseVisualStyleBackColor = true;
            // 
            // gridProductos
            // 
            gridProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProductos.Location = new Point(8, 9);
            gridProductos.Margin = new Padding(5, 4, 5, 4);
            gridProductos.Name = "gridProductos";
            gridProductos.RowHeadersWidth = 51;
            gridProductos.Size = new Size(1305, 829);
            gridProductos.TabIndex = 6;
            // 
            // tabProveedores
            // 
            tabProveedores.Controls.Add(btnEliminarProveedor);
            tabProveedores.Controls.Add(btnAgregarProveedor);
            tabProveedores.Controls.Add(gridProveedores);
            tabProveedores.Location = new Point(4, 29);
            tabProveedores.Margin = new Padding(5, 4, 5, 4);
            tabProveedores.Name = "tabProveedores";
            tabProveedores.Padding = new Padding(5, 4, 5, 4);
            tabProveedores.Size = new Size(1325, 855);
            tabProveedores.TabIndex = 3;
            tabProveedores.Text = "Proveedores";
            tabProveedores.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProveedor
            // 
            btnEliminarProveedor.Location = new Point(971, 108);
            btnEliminarProveedor.Margin = new Padding(5, 4, 5, 4);
            btnEliminarProveedor.Name = "btnEliminarProveedor";
            btnEliminarProveedor.Size = new Size(325, 37);
            btnEliminarProveedor.TabIndex = 5;
            btnEliminarProveedor.Text = "Eliminar Proveedor seleccionado";
            btnEliminarProveedor.UseVisualStyleBackColor = true;
            btnEliminarProveedor.Click += btnEliminarProveedor_Click;
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.Location = new Point(971, 43);
            btnAgregarProveedor.Margin = new Padding(5, 4, 5, 4);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(325, 37);
            btnAgregarProveedor.TabIndex = 4;
            btnAgregarProveedor.Text = "Agregar nuevo Proveedor";
            btnAgregarProveedor.UseVisualStyleBackColor = true;
            btnAgregarProveedor.Click += btnAgregarProveedor_Click;
            // 
            // gridProveedores
            // 
            gridProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProveedores.Location = new Point(8, 9);
            gridProveedores.Margin = new Padding(5, 4, 5, 4);
            gridProveedores.Name = "gridProveedores";
            gridProveedores.RowHeadersWidth = 51;
            gridProveedores.Size = new Size(923, 829);
            gridProveedores.TabIndex = 3;
            // 
            // tabOrdenesDeCompra
            // 
            tabOrdenesDeCompra.Controls.Add(btnDetallesOrden);
            tabOrdenesDeCompra.Controls.Add(btnEliminarOrden);
            tabOrdenesDeCompra.Controls.Add(btnAgregarOrden);
            tabOrdenesDeCompra.Controls.Add(gridOrdenes);
            tabOrdenesDeCompra.Location = new Point(4, 29);
            tabOrdenesDeCompra.Margin = new Padding(5, 4, 5, 4);
            tabOrdenesDeCompra.Name = "tabOrdenesDeCompra";
            tabOrdenesDeCompra.Padding = new Padding(5, 4, 5, 4);
            tabOrdenesDeCompra.Size = new Size(1325, 855);
            tabOrdenesDeCompra.TabIndex = 2;
            tabOrdenesDeCompra.Text = "Órdenes de compra";
            tabOrdenesDeCompra.UseVisualStyleBackColor = true;
            // 
            // btnDetallesOrden
            // 
            btnDetallesOrden.Location = new Point(971, 176);
            btnDetallesOrden.Margin = new Padding(5, 4, 5, 4);
            btnDetallesOrden.Name = "btnDetallesOrden";
            btnDetallesOrden.Size = new Size(325, 37);
            btnDetallesOrden.TabIndex = 6;
            btnDetallesOrden.Text = "Ver detalles de la Orden";
            btnDetallesOrden.UseVisualStyleBackColor = true;
            btnDetallesOrden.Click += btnDetallesOrden_Click;
            // 
            // btnEliminarOrden
            // 
            btnEliminarOrden.Location = new Point(971, 108);
            btnEliminarOrden.Margin = new Padding(5, 4, 5, 4);
            btnEliminarOrden.Name = "btnEliminarOrden";
            btnEliminarOrden.Size = new Size(325, 37);
            btnEliminarOrden.TabIndex = 5;
            btnEliminarOrden.Text = "Eliminar Orden de Compra seleccionada";
            btnEliminarOrden.UseVisualStyleBackColor = true;
            btnEliminarOrden.Click += btnEliminarOrden_Click;
            // 
            // btnAgregarOrden
            // 
            btnAgregarOrden.Location = new Point(971, 43);
            btnAgregarOrden.Margin = new Padding(5, 4, 5, 4);
            btnAgregarOrden.Name = "btnAgregarOrden";
            btnAgregarOrden.Size = new Size(325, 37);
            btnAgregarOrden.TabIndex = 4;
            btnAgregarOrden.Text = "Agregar nueva Orden de Compra";
            btnAgregarOrden.UseVisualStyleBackColor = true;
            btnAgregarOrden.Click += btnAgregarOrden_Click;
            // 
            // gridOrdenes
            // 
            gridOrdenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridOrdenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridOrdenes.Location = new Point(8, 9);
            gridOrdenes.Margin = new Padding(5, 4, 5, 4);
            gridOrdenes.Name = "gridOrdenes";
            gridOrdenes.RowHeadersWidth = 51;
            gridOrdenes.Size = new Size(923, 829);
            gridOrdenes.TabIndex = 3;
            // 
            // tabClientes
            // 
            tabClientes.Controls.Add(btnEliminarCliente);
            tabClientes.Controls.Add(btnAgregarCliente);
            tabClientes.Controls.Add(gridClientes);
            tabClientes.Location = new Point(4, 29);
            tabClientes.Margin = new Padding(5, 4, 5, 4);
            tabClientes.Name = "tabClientes";
            tabClientes.Padding = new Padding(5, 4, 5, 4);
            tabClientes.Size = new Size(1325, 855);
            tabClientes.TabIndex = 1;
            tabClientes.Text = "Clientes";
            tabClientes.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(971, 108);
            btnEliminarCliente.Margin = new Padding(5, 4, 5, 4);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(325, 37);
            btnEliminarCliente.TabIndex = 5;
            btnEliminarCliente.Text = "Eliminar Cliente seleccionado";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(971, 43);
            btnAgregarCliente.Margin = new Padding(5, 4, 5, 4);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(325, 37);
            btnAgregarCliente.TabIndex = 4;
            btnAgregarCliente.Text = "Agregar nuevo Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // gridClientes
            // 
            gridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClientes.Location = new Point(8, 9);
            gridClientes.Margin = new Padding(5, 4, 5, 4);
            gridClientes.Name = "gridClientes";
            gridClientes.RowHeadersWidth = 51;
            gridClientes.Size = new Size(923, 829);
            gridClientes.TabIndex = 3;
            // 
            // tabVentas
            // 
            tabVentas.Controls.Add(btnGenerarReporteVentas);
            tabVentas.Controls.Add(buttonDetallesVenta);
            tabVentas.Controls.Add(btnEliminarVenta);
            tabVentas.Controls.Add(btnAgregarVenta);
            tabVentas.Controls.Add(gridVentas);
            tabVentas.Location = new Point(4, 29);
            tabVentas.Margin = new Padding(5, 4, 5, 4);
            tabVentas.Name = "tabVentas";
            tabVentas.Padding = new Padding(5, 4, 5, 4);
            tabVentas.Size = new Size(1325, 855);
            tabVentas.TabIndex = 0;
            tabVentas.Text = "Ventas";
            tabVentas.UseVisualStyleBackColor = true;
            // 
            // btnGenerarReporteVentas
            // 
            btnGenerarReporteVentas.Location = new Point(971, 241);
            btnGenerarReporteVentas.Margin = new Padding(5, 4, 5, 4);
            btnGenerarReporteVentas.Name = "btnGenerarReporteVentas";
            btnGenerarReporteVentas.Size = new Size(325, 37);
            btnGenerarReporteVentas.TabIndex = 8;
            btnGenerarReporteVentas.Text = "Generar reporte";
            btnGenerarReporteVentas.UseVisualStyleBackColor = true;
            // 
            // buttonDetallesVenta
            // 
            buttonDetallesVenta.Location = new Point(971, 172);
            buttonDetallesVenta.Margin = new Padding(5, 4, 5, 4);
            buttonDetallesVenta.Name = "buttonDetallesVenta";
            buttonDetallesVenta.Size = new Size(325, 37);
            buttonDetallesVenta.TabIndex = 7;
            buttonDetallesVenta.Text = "Ver detalles de la Venta";
            buttonDetallesVenta.UseVisualStyleBackColor = true;
            buttonDetallesVenta.Click += buttonDetallesVenta_Click;
            // 
            // btnEliminarVenta
            // 
            btnEliminarVenta.Location = new Point(971, 108);
            btnEliminarVenta.Margin = new Padding(5, 4, 5, 4);
            btnEliminarVenta.Name = "btnEliminarVenta";
            btnEliminarVenta.Size = new Size(325, 37);
            btnEliminarVenta.TabIndex = 2;
            btnEliminarVenta.Text = "Eliminar Venta";
            btnEliminarVenta.UseVisualStyleBackColor = true;
            btnEliminarVenta.Click += btnEliminarVenta_Click;
            // 
            // btnAgregarVenta
            // 
            btnAgregarVenta.Location = new Point(971, 43);
            btnAgregarVenta.Margin = new Padding(5, 4, 5, 4);
            btnAgregarVenta.Name = "btnAgregarVenta";
            btnAgregarVenta.Size = new Size(325, 37);
            btnAgregarVenta.TabIndex = 1;
            btnAgregarVenta.Text = "Agregar Venta";
            btnAgregarVenta.UseVisualStyleBackColor = true;
            btnAgregarVenta.Click += btnAgregarVenta_Click;
            // 
            // gridVentas
            // 
            gridVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridVentas.Location = new Point(8, 9);
            gridVentas.Margin = new Padding(5, 4, 5, 4);
            gridVentas.Name = "gridVentas";
            gridVentas.RowHeadersWidth = 51;
            gridVentas.Size = new Size(923, 829);
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
            tabControl.Controls.Add(tabAlertas);
            tabControl.Location = new Point(16, 19);
            tabControl.Margin = new Padding(5, 4, 5, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1333, 888);
            tabControl.TabIndex = 0;
            // 
            // tabAlertas
            // 
            tabAlertas.Controls.Add(lblEmail);
            tabAlertas.Controls.Add(tboxEmail);
            tabAlertas.Controls.Add(btnGuardarEmail);
            tabAlertas.Controls.Add(btnAlerta);
            tabAlertas.Location = new Point(4, 29);
            tabAlertas.Margin = new Padding(3, 4, 3, 4);
            tabAlertas.Name = "tabAlertas";
            tabAlertas.Padding = new Padding(3, 4, 3, 4);
            tabAlertas.Size = new Size(1325, 855);
            tabAlertas.TabIndex = 6;
            tabAlertas.Text = "Alertas";
            tabAlertas.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(10, 32);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(131, 20);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email Destinatario";
            // 
            // tboxEmail
            // 
            tboxEmail.Location = new Point(147, 31);
            tboxEmail.Name = "tboxEmail";
            tboxEmail.Size = new Size(199, 27);
            tboxEmail.TabIndex = 4;
            // 
            // btnGuardarEmail
            // 
            btnGuardarEmail.Location = new Point(352, 32);
            btnGuardarEmail.Name = "btnGuardarEmail";
            btnGuardarEmail.Size = new Size(75, 24);
            btnGuardarEmail.TabIndex = 3;
            btnGuardarEmail.Text = "Guardar";
            btnGuardarEmail.UseVisualStyleBackColor = true;
            btnGuardarEmail.Click += btnGuardarEmail_Click;
            // 
            // btnAlerta
            // 
            btnAlerta.Location = new Point(1198, 55);
            btnAlerta.Margin = new Padding(3, 4, 3, 4);
            btnAlerta.Name = "btnAlerta";
            btnAlerta.Size = new Size(86, 31);
            btnAlerta.TabIndex = 0;
            btnAlerta.Text = "Test alerat";
            btnAlerta.Visible = false;
            btnAlerta.Click += btnAlerta_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 924);
            Controls.Add(tabControl);
            Margin = new Padding(5, 4, 5, 4);
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
            tabAlertas.ResumeLayout(false);
            tabAlertas.PerformLayout();
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
        private TabPage tabAlertas;
        private Button btnAlerta;
        private Button btnGenerarReporteVentas;
        private Button btnGuardarEmail;
        private Label lblEmail;
        private TextBox tboxEmail;
    }
}