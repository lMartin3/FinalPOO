﻿namespace PapeleriaGUI
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
            this.gridItems = new System.Windows.Forms.DataGridView();
            this.gbItems = new System.Windows.Forms.GroupBox();
            this.nCantidadItem = new System.Windows.Forms.NumericUpDown();
            this.btnEliminarItem = new System.Windows.Forms.Button();
            this.btnAgregarItem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProductoItem = new System.Windows.Forms.ComboBox();
            this.gbOrden = new System.Windows.Forms.GroupBox();
            this.ventaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbClienteVenta = new System.Windows.Forms.ComboBox();
            this.txtCodigoVenta = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCrearRegistro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
            this.gbItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCantidadItem)).BeginInit();
            this.gbOrden.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridItems
            // 
            this.gridItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItems.Location = new System.Drawing.Point(16, 15);
            this.gridItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridItems.Name = "gridItems";
            this.gridItems.RowHeadersWidth = 51;
            this.gridItems.Size = new System.Drawing.Size(959, 609);
            this.gridItems.TabIndex = 0;
            // 
            // gbItems
            // 
            this.gbItems.Controls.Add(this.nCantidadItem);
            this.gbItems.Controls.Add(this.btnEliminarItem);
            this.gbItems.Controls.Add(this.btnAgregarItem);
            this.gbItems.Controls.Add(this.label2);
            this.gbItems.Controls.Add(this.label1);
            this.gbItems.Controls.Add(this.cbProductoItem);
            this.gbItems.Location = new System.Drawing.Point(1003, 15);
            this.gbItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbItems.Name = "gbItems";
            this.gbItems.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbItems.Size = new System.Drawing.Size(411, 256);
            this.gbItems.TabIndex = 1;
            this.gbItems.TabStop = false;
            this.gbItems.Text = "Items";
            // 
            // nCantidadItem
            // 
            this.nCantidadItem.Location = new System.Drawing.Point(43, 113);
            this.nCantidadItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nCantidadItem.Name = "nCantidadItem";
            this.nCantidadItem.Size = new System.Drawing.Size(339, 22);
            this.nCantidadItem.TabIndex = 8;
            this.nCantidadItem.ValueChanged += new System.EventHandler(this.nCantidadItem_ValueChanged);
            // 
            // btnEliminarItem
            // 
            this.btnEliminarItem.Location = new System.Drawing.Point(39, 209);
            this.btnEliminarItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarItem.Name = "btnEliminarItem";
            this.btnEliminarItem.Size = new System.Drawing.Size(343, 28);
            this.btnEliminarItem.TabIndex = 7;
            this.btnEliminarItem.Text = "Eliminar Item seleccionado";
            this.btnEliminarItem.UseVisualStyleBackColor = true;
            this.btnEliminarItem.Click += new System.EventHandler(this.btnEliminarItem_Click);
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.Location = new System.Drawing.Point(39, 174);
            this.btnAgregarItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(343, 28);
            this.btnAgregarItem.TabIndex = 6;
            this.btnAgregarItem.Text = "Agregar item";
            this.btnAgregarItem.UseVisualStyleBackColor = true;
            this.btnAgregarItem.Click += new System.EventHandler(this.btnAgregarItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            // 
            // cbProductoItem
            // 
            this.cbProductoItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductoItem.FormattingEnabled = true;
            this.cbProductoItem.Location = new System.Drawing.Point(39, 54);
            this.cbProductoItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbProductoItem.Name = "cbProductoItem";
            this.cbProductoItem.Size = new System.Drawing.Size(341, 24);
            this.cbProductoItem.TabIndex = 0;
            this.cbProductoItem.SelectedIndexChanged += new System.EventHandler(this.cbProductoItem_SelectedIndexChanged);
            // 
            // gbOrden
            // 
            this.gbOrden.Controls.Add(this.ventaDateTimePicker);
            this.gbOrden.Controls.Add(this.label3);
            this.gbOrden.Controls.Add(this.label5);
            this.gbOrden.Controls.Add(this.label4);
            this.gbOrden.Controls.Add(this.cbClienteVenta);
            this.gbOrden.Controls.Add(this.txtCodigoVenta);
            this.gbOrden.Controls.Add(this.btnCancelar);
            this.gbOrden.Controls.Add(this.btnCrearRegistro);
            this.gbOrden.Location = new System.Drawing.Point(1003, 300);
            this.gbOrden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbOrden.Name = "gbOrden";
            this.gbOrden.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbOrden.Size = new System.Drawing.Size(411, 324);
            this.gbOrden.TabIndex = 2;
            this.gbOrden.TabStop = false;
            this.gbOrden.Text = "Venta";
            // 
            // ventaDateTimePicker
            // 
            this.ventaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ventaDateTimePicker.Location = new System.Drawing.Point(43, 177);
            this.ventaDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ventaDateTimePicker.Name = "ventaDateTimePicker";
            this.ventaDateTimePicker.Size = new System.Drawing.Size(337, 22);
            this.ventaDateTimePicker.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha Venta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Código de Venta";
            // 
            // cbClienteVenta
            // 
            this.cbClienteVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClienteVenta.FormattingEnabled = true;
            this.cbClienteVenta.Location = new System.Drawing.Point(39, 116);
            this.cbClienteVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbClienteVenta.Name = "cbClienteVenta";
            this.cbClienteVenta.Size = new System.Drawing.Size(341, 24);
            this.cbClienteVenta.TabIndex = 7;
            this.cbClienteVenta.SelectedIndexChanged += new System.EventHandler(this.cbProveedorOrden_SelectedIndexChanged);
            // 
            // txtCodigoVenta
            // 
            this.txtCodigoVenta.Location = new System.Drawing.Point(39, 60);
            this.txtCodigoVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoVenta.Name = "txtCodigoVenta";
            this.txtCodigoVenta.Size = new System.Drawing.Size(341, 22);
            this.txtCodigoVenta.TabIndex = 2;
            this.txtCodigoVenta.TextChanged += new System.EventHandler(this.txtNroOrden_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(39, 273);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(343, 28);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCrearRegistro
            // 
            this.btnCrearRegistro.Location = new System.Drawing.Point(39, 238);
            this.btnCrearRegistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrearRegistro.Name = "btnCrearRegistro";
            this.btnCrearRegistro.Size = new System.Drawing.Size(343, 28);
            this.btnCrearRegistro.TabIndex = 0;
            this.btnCrearRegistro.Text = "Confirmar Registro de Venta";
            this.btnCrearRegistro.UseVisualStyleBackColor = true;
            this.btnCrearRegistro.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCreacionVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 639);
            this.Controls.Add(this.gbOrden);
            this.Controls.Add(this.gbItems);
            this.Controls.Add(this.gridItems);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCreacionVenta";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FormCreacionVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
            this.gbItems.ResumeLayout(false);
            this.gbItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCantidadItem)).EndInit();
            this.gbOrden.ResumeLayout(false);
            this.gbOrden.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridItems;
        private System.Windows.Forms.GroupBox gbItems;
        private System.Windows.Forms.GroupBox gbOrden;
        private System.Windows.Forms.Button btnCrearRegistro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProductoItem;
        private System.Windows.Forms.Button btnAgregarItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbClienteVenta;
        private System.Windows.Forms.TextBox txtCodigoVenta;
        private System.Windows.Forms.Button btnEliminarItem;
        private System.Windows.Forms.NumericUpDown nCantidadItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker ventaDateTimePicker;
    }
}