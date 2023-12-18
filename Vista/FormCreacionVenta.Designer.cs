namespace PapeleriaGUI
{
    partial class FormCreacionVenta
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
            gridItems = new DataGridView();
            gbItems = new GroupBox();
            nCantidadItem = new NumericUpDown();
            btnEliminarItem = new Button();
            btnAgregarItem = new Button();
            label2 = new Label();
            label1 = new Label();
            cbProductoItem = new ComboBox();
            gbOrden = new GroupBox();
            dtpVenta = new DateTimePicker();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            cbClienteVenta = new ComboBox();
            txtCodigoVenta = new TextBox();
            btnCancelar = new Button();
            btnCrearRegistro = new Button();
            ((System.ComponentModel.ISupportInitialize)gridItems).BeginInit();
            gbItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nCantidadItem).BeginInit();
            gbOrden.SuspendLayout();
            SuspendLayout();
            // 
            // gridItems
            // 
            gridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridItems.Location = new Point(14, 14);
            gridItems.Margin = new Padding(4);
            gridItems.Name = "gridItems";
            gridItems.RowHeadersWidth = 51;
            gridItems.Size = new Size(839, 571);
            gridItems.TabIndex = 0;
            // 
            // gbItems
            // 
            gbItems.Controls.Add(nCantidadItem);
            gbItems.Controls.Add(btnEliminarItem);
            gbItems.Controls.Add(btnAgregarItem);
            gbItems.Controls.Add(label2);
            gbItems.Controls.Add(label1);
            gbItems.Controls.Add(cbProductoItem);
            gbItems.Location = new Point(878, 14);
            gbItems.Margin = new Padding(4);
            gbItems.Name = "gbItems";
            gbItems.Padding = new Padding(4);
            gbItems.Size = new Size(360, 240);
            gbItems.TabIndex = 1;
            gbItems.TabStop = false;
            gbItems.Text = "Items";
            // 
            // nCantidadItem
            // 
            nCantidadItem.Location = new Point(38, 106);
            nCantidadItem.Margin = new Padding(4);
            nCantidadItem.Name = "nCantidadItem";
            nCantidadItem.Size = new Size(297, 23);
            nCantidadItem.TabIndex = 8;
            nCantidadItem.ValueChanged += nCantidadItem_ValueChanged;
            // 
            // btnEliminarItem
            // 
            btnEliminarItem.Location = new Point(34, 196);
            btnEliminarItem.Margin = new Padding(4);
            btnEliminarItem.Name = "btnEliminarItem";
            btnEliminarItem.Size = new Size(300, 26);
            btnEliminarItem.TabIndex = 7;
            btnEliminarItem.Text = "Eliminar Item seleccionado";
            btnEliminarItem.UseVisualStyleBackColor = true;
            btnEliminarItem.Click += btnEliminarItem_Click;
            // 
            // btnAgregarItem
            // 
            btnAgregarItem.Location = new Point(34, 163);
            btnAgregarItem.Margin = new Padding(4);
            btnAgregarItem.Name = "btnAgregarItem";
            btnAgregarItem.Size = new Size(300, 26);
            btnAgregarItem.TabIndex = 6;
            btnAgregarItem.Text = "Agregar item";
            btnAgregarItem.UseVisualStyleBackColor = true;
            btnAgregarItem.Click += btnAgregarItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 88);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 4;
            label2.Text = "Cantidad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "Producto";
            // 
            // cbProductoItem
            // 
            cbProductoItem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProductoItem.FormattingEnabled = true;
            cbProductoItem.Location = new Point(34, 51);
            cbProductoItem.Margin = new Padding(4);
            cbProductoItem.Name = "cbProductoItem";
            cbProductoItem.Size = new Size(299, 23);
            cbProductoItem.TabIndex = 0;
            cbProductoItem.SelectedIndexChanged += cbProductoItem_SelectedIndexChanged;
            // 
            // gbOrden
            // 
            gbOrden.Controls.Add(dtpVenta);
            gbOrden.Controls.Add(label3);
            gbOrden.Controls.Add(label5);
            gbOrden.Controls.Add(label4);
            gbOrden.Controls.Add(cbClienteVenta);
            gbOrden.Controls.Add(txtCodigoVenta);
            gbOrden.Controls.Add(btnCancelar);
            gbOrden.Controls.Add(btnCrearRegistro);
            gbOrden.Location = new Point(878, 281);
            gbOrden.Margin = new Padding(4);
            gbOrden.Name = "gbOrden";
            gbOrden.Padding = new Padding(4);
            gbOrden.Size = new Size(360, 304);
            gbOrden.TabIndex = 2;
            gbOrden.TabStop = false;
            gbOrden.Text = "Venta";
            // 
            // dtpVenta
            // 
            dtpVenta.Format = DateTimePickerFormat.Short;
            dtpVenta.Location = new Point(38, 166);
            dtpVenta.Margin = new Padding(4);
            dtpVenta.Name = "dtpVenta";
            dtpVenta.Size = new Size(295, 23);
            dtpVenta.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 148);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 10;
            label3.Text = "Fecha Venta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 90);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 8;
            label5.Text = "Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 38);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 7;
            label4.Text = "Código de Venta";
            // 
            // cbClienteVenta
            // 
            cbClienteVenta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClienteVenta.FormattingEnabled = true;
            cbClienteVenta.Location = new Point(34, 109);
            cbClienteVenta.Margin = new Padding(4);
            cbClienteVenta.Name = "cbClienteVenta";
            cbClienteVenta.Size = new Size(299, 23);
            cbClienteVenta.TabIndex = 7;
            cbClienteVenta.SelectedIndexChanged += cbProveedorOrden_SelectedIndexChanged;
            // 
            // txtCodigoVenta
            // 
            txtCodigoVenta.Location = new Point(34, 56);
            txtCodigoVenta.Margin = new Padding(4);
            txtCodigoVenta.Name = "txtCodigoVenta";
            txtCodigoVenta.Size = new Size(299, 23);
            txtCodigoVenta.TabIndex = 2;
            txtCodigoVenta.TextChanged += txtNroOrden_TextChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(34, 256);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(300, 26);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCrearRegistro
            // 
            btnCrearRegistro.Location = new Point(34, 223);
            btnCrearRegistro.Margin = new Padding(4);
            btnCrearRegistro.Name = "btnCrearRegistro";
            btnCrearRegistro.Size = new Size(300, 26);
            btnCrearRegistro.TabIndex = 0;
            btnCrearRegistro.Text = "Confirmar Registro de Venta";
            btnCrearRegistro.UseVisualStyleBackColor = true;
            btnCrearRegistro.Click += button1_Click;
            // 
            // FormCreacionVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 599);
            Controls.Add(gbOrden);
            Controls.Add(gbItems);
            Controls.Add(gridItems);
            Margin = new Padding(4);
            Name = "FormCreacionVenta";
            Text = "Form3";
            Load += FormCreacionVenta_Load;
            ((System.ComponentModel.ISupportInitialize)gridItems).EndInit();
            gbItems.ResumeLayout(false);
            gbItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nCantidadItem).EndInit();
            gbOrden.ResumeLayout(false);
            gbOrden.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridItems;
        private GroupBox gbItems;
        private GroupBox gbOrden;
        private Button btnCrearRegistro;
        private Button btnCancelar;
        private Label label1;
        private ComboBox cbProductoItem;
        private Button btnAgregarItem;
        private Label label2;
        private Label label5;
        private Label label4;
        private ComboBox cbClienteVenta;
        private TextBox txtCodigoVenta;
        private Button btnEliminarItem;
        private NumericUpDown nCantidadItem;
        private Label label3;
        private DateTimePicker dtpVenta;
    }
}