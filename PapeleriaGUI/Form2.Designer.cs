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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabVentas = new System.Windows.Forms.TabPage();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.tabOrdenesDeCompra = new System.Windows.Forms.TabPage();
            this.tabProveedores = new System.Windows.Forms.TabPage();
            this.gridVentas = new System.Windows.Forms.DataGridView();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.btnEliminarVenta = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabVentas);
            this.tabControl1.Controls.Add(this.tabClientes);
            this.tabControl1.Controls.Add(this.tabOrdenesDeCompra);
            this.tabControl1.Controls.Add(this.tabProveedores);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(999, 577);
            this.tabControl1.TabIndex = 0;
            // 
            // tabVentas
            // 
            this.tabVentas.Controls.Add(this.btnEliminarVenta);
            this.tabVentas.Controls.Add(this.btnAgregarVenta);
            this.tabVentas.Controls.Add(this.gridVentas);
            this.tabVentas.Location = new System.Drawing.Point(4, 22);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabVentas.Size = new System.Drawing.Size(991, 551);
            this.tabVentas.TabIndex = 0;
            this.tabVentas.Text = "Ventas";
            this.tabVentas.UseVisualStyleBackColor = true;
            // 
            // tabClientes
            // 
            this.tabClientes.Location = new System.Drawing.Point(4, 22);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(991, 551);
            this.tabClientes.TabIndex = 1;
            this.tabClientes.Text = "Clientes";
            this.tabClientes.UseVisualStyleBackColor = true;
            // 
            // tabOrdenesDeCompra
            // 
            this.tabOrdenesDeCompra.Location = new System.Drawing.Point(4, 22);
            this.tabOrdenesDeCompra.Name = "tabOrdenesDeCompra";
            this.tabOrdenesDeCompra.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrdenesDeCompra.Size = new System.Drawing.Size(991, 551);
            this.tabOrdenesDeCompra.TabIndex = 2;
            this.tabOrdenesDeCompra.Text = "Órdenes de compra";
            this.tabOrdenesDeCompra.UseVisualStyleBackColor = true;
            // 
            // tabProveedores
            // 
            this.tabProveedores.Location = new System.Drawing.Point(4, 22);
            this.tabProveedores.Name = "tabProveedores";
            this.tabProveedores.Padding = new System.Windows.Forms.Padding(3);
            this.tabProveedores.Size = new System.Drawing.Size(991, 551);
            this.tabProveedores.TabIndex = 3;
            this.tabProveedores.Text = "Proveedores";
            this.tabProveedores.UseVisualStyleBackColor = true;
            // 
            // gridVentas
            // 
            this.gridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVentas.Location = new System.Drawing.Point(6, 6);
            this.gridVentas.Name = "gridVentas";
            this.gridVentas.Size = new System.Drawing.Size(693, 539);
            this.gridVentas.TabIndex = 0;
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.Location = new System.Drawing.Point(728, 28);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(244, 24);
            this.btnAgregarVenta.TabIndex = 1;
            this.btnAgregarVenta.Text = "Agregar Venta";
            this.btnAgregarVenta.UseVisualStyleBackColor = true;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // btnEliminarVenta
            // 
            this.btnEliminarVenta.Location = new System.Drawing.Point(728, 70);
            this.btnEliminarVenta.Name = "btnEliminarVenta";
            this.btnEliminarVenta.Size = new System.Drawing.Size(244, 24);
            this.btnEliminarVenta.TabIndex = 2;
            this.btnEliminarVenta.Text = "Eliminar Venta";
            this.btnEliminarVenta.UseVisualStyleBackColor = true;
            this.btnEliminarVenta.Click += new System.EventHandler(this.btnEliminarVenta_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 601);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.tabVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabVentas;
        private System.Windows.Forms.DataGridView gridVentas;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.TabPage tabOrdenesDeCompra;
        private System.Windows.Forms.TabPage tabProveedores;
        private System.Windows.Forms.Button btnEliminarVenta;
        private System.Windows.Forms.Button btnAgregarVenta;
    }
}