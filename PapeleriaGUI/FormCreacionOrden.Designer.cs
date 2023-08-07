namespace PapeleriaGUI
{
    partial class FormCreacionOrden
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
            this.gridItems = new System.Windows.Forms.DataGridView();
            this.gbItems = new System.Windows.Forms.GroupBox();
            this.gbOrden = new System.Windows.Forms.GroupBox();
            this.btnCrearOrden = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbProductoItem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadItem = new System.Windows.Forms.TextBox();
            this.txtPrecioItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarItem = new System.Windows.Forms.Button();
            this.txtNroOrden = new System.Windows.Forms.TextBox();
            this.cbProveedorOrden = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminarItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
            this.gbItems.SuspendLayout();
            this.gbOrden.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridItems
            // 
            this.gridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItems.Location = new System.Drawing.Point(12, 12);
            this.gridItems.Name = "gridItems";
            this.gridItems.Size = new System.Drawing.Size(719, 495);
            this.gridItems.TabIndex = 0;
            // 
            // gbItems
            // 
            this.gbItems.Controls.Add(this.btnEliminarItem);
            this.gbItems.Controls.Add(this.btnAgregarItem);
            this.gbItems.Controls.Add(this.label3);
            this.gbItems.Controls.Add(this.label2);
            this.gbItems.Controls.Add(this.txtPrecioItem);
            this.gbItems.Controls.Add(this.txtCantidadItem);
            this.gbItems.Controls.Add(this.label1);
            this.gbItems.Controls.Add(this.cbProductoItem);
            this.gbItems.Location = new System.Drawing.Point(752, 12);
            this.gbItems.Name = "gbItems";
            this.gbItems.Size = new System.Drawing.Size(308, 262);
            this.gbItems.TabIndex = 1;
            this.gbItems.TabStop = false;
            this.gbItems.Text = "Items";
            // 
            // gbOrden
            // 
            this.gbOrden.Controls.Add(this.label5);
            this.gbOrden.Controls.Add(this.label4);
            this.gbOrden.Controls.Add(this.cbProveedorOrden);
            this.gbOrden.Controls.Add(this.txtNroOrden);
            this.gbOrden.Controls.Add(this.btnCancelar);
            this.gbOrden.Controls.Add(this.btnCrearOrden);
            this.gbOrden.Location = new System.Drawing.Point(752, 309);
            this.gbOrden.Name = "gbOrden";
            this.gbOrden.Size = new System.Drawing.Size(308, 198);
            this.gbOrden.TabIndex = 2;
            this.gbOrden.TabStop = false;
            this.gbOrden.Text = "Orden de Compra";
            // 
            // btnCrearOrden
            // 
            this.btnCrearOrden.Location = new System.Drawing.Point(29, 134);
            this.btnCrearOrden.Name = "btnCrearOrden";
            this.btnCrearOrden.Size = new System.Drawing.Size(257, 23);
            this.btnCrearOrden.TabIndex = 0;
            this.btnCrearOrden.Text = "Confirmar orden de compra";
            this.btnCrearOrden.UseVisualStyleBackColor = true;
            this.btnCrearOrden.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(29, 163);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(257, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbProductoItem
            // 
            this.cbProductoItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductoItem.FormattingEnabled = true;
            this.cbProductoItem.Location = new System.Drawing.Point(29, 44);
            this.cbProductoItem.Name = "cbProductoItem";
            this.cbProductoItem.Size = new System.Drawing.Size(257, 21);
            this.cbProductoItem.TabIndex = 0;
            this.cbProductoItem.SelectedIndexChanged += new System.EventHandler(this.cbProductoItem_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            // 
            // txtCantidadItem
            // 
            this.txtCantidadItem.Location = new System.Drawing.Point(29, 92);
            this.txtCantidadItem.Name = "txtCantidadItem";
            this.txtCantidadItem.Size = new System.Drawing.Size(257, 20);
            this.txtCantidadItem.TabIndex = 2;
            this.txtCantidadItem.TextChanged += new System.EventHandler(this.txtCantidadItem_TextChanged);
            // 
            // txtPrecioItem
            // 
            this.txtPrecioItem.Location = new System.Drawing.Point(29, 144);
            this.txtPrecioItem.Name = "txtPrecioItem";
            this.txtPrecioItem.Size = new System.Drawing.Size(257, 20);
            this.txtPrecioItem.TabIndex = 3;
            this.txtPrecioItem.TextChanged += new System.EventHandler(this.txtPrecioItem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio unitario";
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.Location = new System.Drawing.Point(29, 194);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(257, 23);
            this.btnAgregarItem.TabIndex = 6;
            this.btnAgregarItem.Text = "Agregar item";
            this.btnAgregarItem.UseVisualStyleBackColor = true;
            this.btnAgregarItem.Click += new System.EventHandler(this.btnAgregarItem_Click);
            // 
            // txtNroOrden
            // 
            this.txtNroOrden.Location = new System.Drawing.Point(29, 49);
            this.txtNroOrden.Name = "txtNroOrden";
            this.txtNroOrden.Size = new System.Drawing.Size(257, 20);
            this.txtNroOrden.TabIndex = 2;
            // 
            // cbProveedorOrden
            // 
            this.cbProveedorOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProveedorOrden.FormattingEnabled = true;
            this.cbProveedorOrden.Location = new System.Drawing.Point(29, 94);
            this.cbProveedorOrden.Name = "cbProveedorOrden";
            this.cbProveedorOrden.Size = new System.Drawing.Size(257, 21);
            this.cbProveedorOrden.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nro de la Orden";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Proveedor";
            // 
            // btnEliminarItem
            // 
            this.btnEliminarItem.Location = new System.Drawing.Point(29, 223);
            this.btnEliminarItem.Name = "btnEliminarItem";
            this.btnEliminarItem.Size = new System.Drawing.Size(257, 23);
            this.btnEliminarItem.TabIndex = 7;
            this.btnEliminarItem.Text = "Eliminar Item seleccionado";
            this.btnEliminarItem.UseVisualStyleBackColor = true;
            // 
            // FormCreacionOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 519);
            this.Controls.Add(this.gbOrden);
            this.Controls.Add(this.gbItems);
            this.Controls.Add(this.gridItems);
            this.Name = "FormCreacionOrden";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
            this.gbItems.ResumeLayout(false);
            this.gbItems.PerformLayout();
            this.gbOrden.ResumeLayout(false);
            this.gbOrden.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridItems;
        private System.Windows.Forms.GroupBox gbItems;
        private System.Windows.Forms.GroupBox gbOrden;
        private System.Windows.Forms.Button btnCrearOrden;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProductoItem;
        private System.Windows.Forms.TextBox txtPrecioItem;
        private System.Windows.Forms.TextBox txtCantidadItem;
        private System.Windows.Forms.Button btnAgregarItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbProveedorOrden;
        private System.Windows.Forms.TextBox txtNroOrden;
        private System.Windows.Forms.Button btnEliminarItem;
    }
}