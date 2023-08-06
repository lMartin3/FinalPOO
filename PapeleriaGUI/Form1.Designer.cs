namespace PapeleriaGUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemsVentaDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonRegistrarVenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.itemVentaProductoComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ventaIDnumericUD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.anadirItemDeVentaButton = new System.Windows.Forms.Button();
            this.borrarTodosButton = new System.Windows.Forms.Button();
            this.borrarItemSeleccionadoButton = new System.Windows.Forms.Button();
            this.ventaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.itemsVentaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaIDnumericUD)).BeginInit();
            this.SuspendLayout();
            // 
            // itemsVentaDataGridView
            // 
            this.itemsVentaDataGridView.AllowUserToAddRows = false;
            this.itemsVentaDataGridView.AllowUserToDeleteRows = false;
            this.itemsVentaDataGridView.AllowUserToResizeColumns = false;
            this.itemsVentaDataGridView.AllowUserToResizeRows = false;
            this.itemsVentaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemsVentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsVentaDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.itemsVentaDataGridView.Location = new System.Drawing.Point(12, 12);
            this.itemsVentaDataGridView.MultiSelect = false;
            this.itemsVentaDataGridView.Name = "itemsVentaDataGridView";
            this.itemsVentaDataGridView.ReadOnly = true;
            this.itemsVentaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsVentaDataGridView.Size = new System.Drawing.Size(714, 356);
            this.itemsVentaDataGridView.TabIndex = 0;
            // 
            // buttonRegistrarVenta
            // 
            this.buttonRegistrarVenta.Location = new System.Drawing.Point(765, 547);
            this.buttonRegistrarVenta.Name = "buttonRegistrarVenta";
            this.buttonRegistrarVenta.Size = new System.Drawing.Size(100, 28);
            this.buttonRegistrarVenta.TabIndex = 2;
            this.buttonRegistrarVenta.Text = "Registrar Venta";
            this.buttonRegistrarVenta.UseVisualStyleBackColor = true;
            this.buttonRegistrarVenta.Click += new System.EventHandler(this.buttonRegistrarVenta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Producto";
            // 
            // itemVentaProductoComboBox
            // 
            this.itemVentaProductoComboBox.FormattingEnabled = true;
            this.itemVentaProductoComboBox.Location = new System.Drawing.Point(67, 453);
            this.itemVentaProductoComboBox.Name = "itemVentaProductoComboBox";
            this.itemVentaProductoComboBox.Size = new System.Drawing.Size(121, 21);
            this.itemVentaProductoComboBox.TabIndex = 4;
            this.itemVentaProductoComboBox.SelectedIndexChanged += new System.EventHandler(this.itemVentaProductoComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad";
            // 
            // cantidadNumericUpDown
            // 
            this.cantidadNumericUpDown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cantidadNumericUpDown.Location = new System.Drawing.Point(250, 454);
            this.cantidadNumericUpDown.Name = "cantidadNumericUpDown";
            this.cantidadNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.cantidadNumericUpDown.TabIndex = 7;
            this.cantidadNumericUpDown.TabStop = false;
            // 
            // clienteComboBox
            // 
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.Location = new System.Drawing.Point(691, 429);
            this.clienteComboBox.Name = "clienteComboBox";
            this.clienteComboBox.Size = new System.Drawing.Size(121, 21);
            this.clienteComboBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(725, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cliente";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(884, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID";
            // 
            // ventaIDnumericUD
            // 
            this.ventaIDnumericUD.Location = new System.Drawing.Point(835, 430);
            this.ventaIDnumericUD.Name = "ventaIDnumericUD";
            this.ventaIDnumericUD.Size = new System.Drawing.Size(120, 20);
            this.ventaIDnumericUD.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(800, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // anadirItemDeVentaButton
            // 
            this.anadirItemDeVentaButton.Location = new System.Drawing.Point(155, 529);
            this.anadirItemDeVentaButton.Name = "anadirItemDeVentaButton";
            this.anadirItemDeVentaButton.Size = new System.Drawing.Size(118, 28);
            this.anadirItemDeVentaButton.TabIndex = 14;
            this.anadirItemDeVentaButton.Text = "Añadir Item de Venta";
            this.anadirItemDeVentaButton.UseVisualStyleBackColor = true;
            this.anadirItemDeVentaButton.Click += new System.EventHandler(this.anadirItemDeVentaButton_Click);
            // 
            // borrarTodosButton
            // 
            this.borrarTodosButton.Location = new System.Drawing.Point(776, 191);
            this.borrarTodosButton.Name = "borrarTodosButton";
            this.borrarTodosButton.Size = new System.Drawing.Size(152, 28);
            this.borrarTodosButton.TabIndex = 16;
            this.borrarTodosButton.Text = "Borrar Todos Los Items";
            this.borrarTodosButton.UseVisualStyleBackColor = true;
            this.borrarTodosButton.Click += new System.EventHandler(this.borrarTodosButton_Click);
            // 
            // borrarItemSeleccionadoButton
            // 
            this.borrarItemSeleccionadoButton.Location = new System.Drawing.Point(776, 92);
            this.borrarItemSeleccionadoButton.Name = "borrarItemSeleccionadoButton";
            this.borrarItemSeleccionadoButton.Size = new System.Drawing.Size(152, 28);
            this.borrarItemSeleccionadoButton.TabIndex = 17;
            this.borrarItemSeleccionadoButton.Text = "Borrar Item Seleccionado";
            this.borrarItemSeleccionadoButton.UseVisualStyleBackColor = true;
            this.borrarItemSeleccionadoButton.Click += new System.EventHandler(this.borrarItemSeleccionadoButton_Click);
            // 
            // ventaDateTimePicker
            // 
            this.ventaDateTimePicker.Location = new System.Drawing.Point(728, 503);
            this.ventaDateTimePicker.Name = "ventaDateTimePicker";
            this.ventaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ventaDateTimePicker.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 627);
            this.Controls.Add(this.ventaDateTimePicker);
            this.Controls.Add(this.borrarItemSeleccionadoButton);
            this.Controls.Add(this.borrarTodosButton);
            this.Controls.Add(this.anadirItemDeVentaButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ventaIDnumericUD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clienteComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cantidadNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemVentaProductoComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRegistrarVenta);
            this.Controls.Add(this.itemsVentaDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsVentaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaIDnumericUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView itemsVentaDataGridView;
        private System.Windows.Forms.Button buttonRegistrarVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox itemVentaProductoComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown cantidadNumericUpDown;
        private System.Windows.Forms.ComboBox clienteComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ventaIDnumericUD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button anadirItemDeVentaButton;
        private System.Windows.Forms.Button borrarTodosButton;
        private System.Windows.Forms.Button borrarItemSeleccionadoButton;
        private System.Windows.Forms.DateTimePicker ventaDateTimePicker;
    }
}

