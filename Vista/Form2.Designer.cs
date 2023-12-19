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
            this.tabCategorias = new System.Windows.Forms.TabPage();
            this.gridCategorias = new System.Windows.Forms.DataGridView();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.tabProveedores = new System.Windows.Forms.TabPage();
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.gridProveedores = new System.Windows.Forms.DataGridView();
            this.tabOrdenesDeCompra = new System.Windows.Forms.TabPage();
            this.btnDetallesOrden = new System.Windows.Forms.Button();
            this.btnEliminarOrden = new System.Windows.Forms.Button();
            this.btnAgregarOrden = new System.Windows.Forms.Button();
            this.gridOrdenes = new System.Windows.Forms.DataGridView();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.tabVentas = new System.Windows.Forms.TabPage();
            this.btnGenerarReporteVentas = new System.Windows.Forms.Button();
            this.buttonDetallesVenta = new System.Windows.Forms.Button();
            this.btnEliminarVenta = new System.Windows.Forms.Button();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.gridVentas = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAlertas = new System.Windows.Forms.TabPage();
            this.btnAlerta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxEmail = new System.Windows.Forms.ComboBox();
            this.btnGuardarEmail = new System.Windows.Forms.Button();
            this.tabCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategorias)).BeginInit();
            this.tabProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.tabProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProveedores)).BeginInit();
            this.tabOrdenesDeCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrdenes)).BeginInit();
            this.tabClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.tabVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVentas)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabAlertas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCategorias
            // 
            this.tabCategorias.Controls.Add(this.gridCategorias);
            this.tabCategorias.Location = new System.Drawing.Point(4, 28);
            this.tabCategorias.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabCategorias.Name = "tabCategorias";
            this.tabCategorias.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabCategorias.Size = new System.Drawing.Size(1325, 812);
            this.tabCategorias.TabIndex = 5;
            this.tabCategorias.Text = "Categorías de Producto";
            this.tabCategorias.UseVisualStyleBackColor = true;
            // 
            // gridCategorias
            // 
            this.gridCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCategorias.Location = new System.Drawing.Point(8, 9);
            this.gridCategorias.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gridCategorias.Name = "gridCategorias";
            this.gridCategorias.Size = new System.Drawing.Size(1305, 788);
            this.gridCategorias.TabIndex = 9;
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.gridProductos);
            this.tabProductos.Location = new System.Drawing.Point(4, 28);
            this.tabProductos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabProductos.Size = new System.Drawing.Size(1325, 812);
            this.tabProductos.TabIndex = 4;
            this.tabProductos.Text = "Productos";
            this.tabProductos.UseVisualStyleBackColor = true;
            // 
            // gridProductos
            // 
            this.gridProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Location = new System.Drawing.Point(8, 9);
            this.gridProductos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(1305, 788);
            this.gridProductos.TabIndex = 6;
            // 
            // tabProveedores
            // 
            this.tabProveedores.Controls.Add(this.btnEliminarProveedor);
            this.tabProveedores.Controls.Add(this.btnAgregarProveedor);
            this.tabProveedores.Controls.Add(this.gridProveedores);
            this.tabProveedores.Location = new System.Drawing.Point(4, 28);
            this.tabProveedores.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabProveedores.Name = "tabProveedores";
            this.tabProveedores.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabProveedores.Size = new System.Drawing.Size(1325, 812);
            this.tabProveedores.TabIndex = 3;
            this.tabProveedores.Text = "Proveedores";
            this.tabProveedores.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.Location = new System.Drawing.Point(971, 103);
            this.btnEliminarProveedor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(325, 35);
            this.btnEliminarProveedor.TabIndex = 5;
            this.btnEliminarProveedor.Text = "Eliminar Proveedor seleccionado";
            this.btnEliminarProveedor.UseVisualStyleBackColor = true;
            btnEliminarProveedor.Click += btnEliminarProveedor_Click;
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.Location = new System.Drawing.Point(971, 41);
            this.btnAgregarProveedor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(325, 35);
            this.btnAgregarProveedor.TabIndex = 4;
            this.btnAgregarProveedor.Text = "Agregar nuevo Proveedor";
            this.btnAgregarProveedor.UseVisualStyleBackColor = true;
            btnAgregarProveedor.Click += btnAgregarProveedor_Click;
            // 
            // gridProveedores
            // 
            this.gridProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProveedores.Location = new System.Drawing.Point(8, 9);
            this.gridProveedores.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gridProveedores.Name = "gridProveedores";
            this.gridProveedores.Size = new System.Drawing.Size(923, 788);
            this.gridProveedores.TabIndex = 3;
            // 
            // tabOrdenesDeCompra
            // 
            this.tabOrdenesDeCompra.Controls.Add(this.btnDetallesOrden);
            this.tabOrdenesDeCompra.Controls.Add(this.btnEliminarOrden);
            this.tabOrdenesDeCompra.Controls.Add(this.btnAgregarOrden);
            this.tabOrdenesDeCompra.Controls.Add(this.gridOrdenes);
            this.tabOrdenesDeCompra.Location = new System.Drawing.Point(4, 28);
            this.tabOrdenesDeCompra.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabOrdenesDeCompra.Name = "tabOrdenesDeCompra";
            this.tabOrdenesDeCompra.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabOrdenesDeCompra.Size = new System.Drawing.Size(1325, 812);
            this.tabOrdenesDeCompra.TabIndex = 2;
            this.tabOrdenesDeCompra.Text = "Órdenes de compra";
            this.tabOrdenesDeCompra.UseVisualStyleBackColor = true;
            // 
            // btnDetallesOrden
            // 
            this.btnDetallesOrden.Location = new System.Drawing.Point(971, 167);
            this.btnDetallesOrden.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDetallesOrden.Name = "btnDetallesOrden";
            this.btnDetallesOrden.Size = new System.Drawing.Size(325, 35);
            this.btnDetallesOrden.TabIndex = 6;
            this.btnDetallesOrden.Text = "Ver detalles de la Orden";
            this.btnDetallesOrden.UseVisualStyleBackColor = true;
            btnDetallesOrden.Click += btnDetallesOrden_Click;
            // 
            // btnEliminarOrden
            // 
            this.btnEliminarOrden.Location = new System.Drawing.Point(971, 103);
            this.btnEliminarOrden.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEliminarOrden.Name = "btnEliminarOrden";
            this.btnEliminarOrden.Size = new System.Drawing.Size(325, 35);
            this.btnEliminarOrden.TabIndex = 5;
            this.btnEliminarOrden.Text = "Eliminar Orden de Compra seleccionada";
            this.btnEliminarOrden.UseVisualStyleBackColor = true;
            btnEliminarOrden.Click += btnEliminarOrden_Click;
            // 
            // btnAgregarOrden
            // 
            this.btnAgregarOrden.Location = new System.Drawing.Point(971, 41);
            this.btnAgregarOrden.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAgregarOrden.Name = "btnAgregarOrden";
            this.btnAgregarOrden.Size = new System.Drawing.Size(325, 35);
            this.btnAgregarOrden.TabIndex = 4;
            this.btnAgregarOrden.Text = "Agregar nueva Orden de Compra";
            this.btnAgregarOrden.UseVisualStyleBackColor = true;
            btnAgregarOrden.Click += btnAgregarOrden_Click;
            // 
            // gridOrdenes
            // 
            this.gridOrdenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrdenes.Location = new System.Drawing.Point(8, 9);
            this.gridOrdenes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gridOrdenes.Name = "gridOrdenes";
            this.gridOrdenes.Size = new System.Drawing.Size(923, 788);
            this.gridOrdenes.TabIndex = 3;
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.btnEliminarCliente);
            this.tabClientes.Controls.Add(this.btnAgregarCliente);
            this.tabClientes.Controls.Add(this.gridClientes);
            this.tabClientes.Location = new System.Drawing.Point(4, 28);
            this.tabClientes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabClientes.Size = new System.Drawing.Size(1325, 812);
            this.tabClientes.TabIndex = 1;
            this.tabClientes.Text = "Clientes";
            this.tabClientes.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(971, 103);
            this.btnEliminarCliente.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(325, 35);
            this.btnEliminarCliente.TabIndex = 5;
            this.btnEliminarCliente.Text = "Eliminar Cliente seleccionado";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(971, 41);
            this.btnAgregarCliente.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(325, 35);
            this.btnAgregarCliente.TabIndex = 4;
            this.btnAgregarCliente.Text = "Agregar nuevo Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // gridClientes
            // 
            this.gridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Location = new System.Drawing.Point(8, 9);
            this.gridClientes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.Size = new System.Drawing.Size(923, 788);
            this.gridClientes.TabIndex = 3;
            // 
            // tabVentas
            // 
            this.tabVentas.Controls.Add(this.btnGenerarReporteVentas);
            this.tabVentas.Controls.Add(this.buttonDetallesVenta);
            this.tabVentas.Controls.Add(this.btnEliminarVenta);
            this.tabVentas.Controls.Add(this.btnAgregarVenta);
            this.tabVentas.Controls.Add(this.gridVentas);
            this.tabVentas.Location = new System.Drawing.Point(4, 28);
            this.tabVentas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabVentas.Size = new System.Drawing.Size(1325, 812);
            this.tabVentas.TabIndex = 0;
            this.tabVentas.Text = "Ventas";
            this.tabVentas.UseVisualStyleBackColor = true;
            // 
            // btnGenerarReporteVentas
            // 
            this.btnGenerarReporteVentas.Location = new System.Drawing.Point(971, 229);
            this.btnGenerarReporteVentas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGenerarReporteVentas.Name = "btnGenerarReporteVentas";
            this.btnGenerarReporteVentas.Size = new System.Drawing.Size(325, 35);
            this.btnGenerarReporteVentas.TabIndex = 8;
            this.btnGenerarReporteVentas.Text = "Generar reporte";
            this.btnGenerarReporteVentas.UseVisualStyleBackColor = true;
            // 
            // buttonDetallesVenta
            // 
            this.buttonDetallesVenta.Location = new System.Drawing.Point(971, 163);
            this.buttonDetallesVenta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonDetallesVenta.Name = "buttonDetallesVenta";
            this.buttonDetallesVenta.Size = new System.Drawing.Size(325, 35);
            this.buttonDetallesVenta.TabIndex = 7;
            this.buttonDetallesVenta.Text = "Ver detalles de la Venta";
            this.buttonDetallesVenta.UseVisualStyleBackColor = true;
            buttonDetallesVenta.Click += buttonDetallesVenta_Click;
            // 
            // btnEliminarVenta
            // 
            this.btnEliminarVenta.Location = new System.Drawing.Point(971, 103);
            this.btnEliminarVenta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEliminarVenta.Name = "btnEliminarVenta";
            this.btnEliminarVenta.Size = new System.Drawing.Size(325, 35);
            this.btnEliminarVenta.TabIndex = 2;
            this.btnEliminarVenta.Text = "Eliminar Venta";
            this.btnEliminarVenta.UseVisualStyleBackColor = true;
            btnEliminarVenta.Click += btnEliminarVenta_Click;
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.Location = new System.Drawing.Point(971, 41);
            this.btnAgregarVenta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(325, 35);
            this.btnAgregarVenta.TabIndex = 1;
            this.btnAgregarVenta.Text = "Agregar Venta";
            this.btnAgregarVenta.UseVisualStyleBackColor = true;
            btnAgregarVenta.Click += btnAgregarVenta_Click;
            // 
            // gridVentas
            // 
            this.gridVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVentas.Location = new System.Drawing.Point(8, 9);
            this.gridVentas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gridVentas.Name = "gridVentas";
            this.gridVentas.Size = new System.Drawing.Size(923, 788);
            this.gridVentas.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabVentas);
            this.tabControl.Controls.Add(this.tabClientes);
            this.tabControl.Controls.Add(this.tabOrdenesDeCompra);
            this.tabControl.Controls.Add(this.tabProveedores);
            this.tabControl.Controls.Add(this.tabProductos);
            this.tabControl.Controls.Add(this.tabCategorias);
            this.tabControl.Controls.Add(this.tabAlertas);
            this.tabControl.Location = new System.Drawing.Point(16, 18);
            this.tabControl.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1333, 844);
            this.tabControl.TabIndex = 0;
            // 
            // tabAlertas
            // 
            this.tabAlertas.Controls.Add(this.btnGuardarEmail);
            this.tabAlertas.Controls.Add(this.cboxEmail);
            this.tabAlertas.Controls.Add(this.label1);
            this.tabAlertas.Controls.Add(this.btnAlerta);
            this.tabAlertas.Location = new System.Drawing.Point(4, 28);
            this.tabAlertas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAlertas.Name = "tabAlertas";
            this.tabAlertas.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAlertas.Size = new System.Drawing.Size(1325, 812);
            this.tabAlertas.TabIndex = 6;
            this.tabAlertas.Text = "Alertas";
            this.tabAlertas.UseVisualStyleBackColor = true;
            // 
            // btnAlerta
            // 
            this.btnAlerta.Location = new System.Drawing.Point(1198, 52);
            this.btnAlerta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlerta.Name = "btnAlerta";
            this.btnAlerta.Size = new System.Drawing.Size(86, 29);
            this.btnAlerta.TabIndex = 0;
            this.btnAlerta.Text = "Test alerat";
            btnAlerta.Click += btnAlerta_Click;
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // cboxEmail
            // 
            this.cboxEmail.FormattingEnabled = true;
            this.cboxEmail.Location = new System.Drawing.Point(98, 34);
            this.cboxEmail.Name = "cboxEmail";
            this.cboxEmail.Size = new System.Drawing.Size(121, 27);
            this.cboxEmail.TabIndex = 2;
            // 
            // btnGuardarEmail
            // 
            this.btnGuardarEmail.Location = new System.Drawing.Point(248, 35);
            this.btnGuardarEmail.Name = "btnGuardarEmail";
            this.btnGuardarEmail.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarEmail.TabIndex = 3;
            this.btnGuardarEmail.Text = "Guardar";
            this.btnGuardarEmail.UseVisualStyleBackColor = true;
            this.btnGuardarEmail.Click += new System.EventHandler(this.btnGuardarEmail_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 878);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form2";
            this.Text = "Papelería";
            this.tabCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCategorias)).EndInit();
            this.tabProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.tabProveedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProveedores)).EndInit();
            this.tabOrdenesDeCompra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrdenes)).EndInit();
            this.tabClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.tabVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVentas)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabAlertas.ResumeLayout(false);
            this.tabAlertas.PerformLayout();
            this.ResumeLayout(false);

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
        private ComboBox cboxEmail;
        private Label label1;
    }
}