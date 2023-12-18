namespace Vista
{
    partial class FormCreacionReporte
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
            calPeriodo = new MonthCalendar();
            btnCrearReporte = new Button();
            cbFormato = new ComboBox();
            cbAbrirArchivo = new CheckBox();
            SuspendLayout();
            // 
            // calPeriodo
            // 
            calPeriodo.Location = new Point(18, 18);
            calPeriodo.MaxSelectionCount = 31;
            calPeriodo.Name = "calPeriodo";
            calPeriodo.TabIndex = 0;
            // 
            // btnCrearReporte
            // 
            btnCrearReporte.Location = new Point(18, 256);
            btnCrearReporte.Name = "btnCrearReporte";
            btnCrearReporte.Size = new Size(227, 23);
            btnCrearReporte.TabIndex = 1;
            btnCrearReporte.Text = "Generar reporte";
            btnCrearReporte.UseVisualStyleBackColor = true;
            btnCrearReporte.Click += btnCrearReporte_Click;
            // 
            // cbFormato
            // 
            cbFormato.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFormato.FormattingEnabled = true;
            cbFormato.Location = new Point(18, 192);
            cbFormato.Name = "cbFormato";
            cbFormato.Size = new Size(227, 23);
            cbFormato.TabIndex = 2;
            // 
            // cbAbrirArchivo
            // 
            cbAbrirArchivo.AutoSize = true;
            cbAbrirArchivo.Checked = true;
            cbAbrirArchivo.CheckState = CheckState.Checked;
            cbAbrirArchivo.Location = new Point(18, 221);
            cbAbrirArchivo.Name = "cbAbrirArchivo";
            cbAbrirArchivo.Size = new Size(199, 19);
            cbAbrirArchivo.TabIndex = 3;
            cbAbrirArchivo.Text = "Abrir archivo después de generar";
            cbAbrirArchivo.UseVisualStyleBackColor = true;
            cbAbrirArchivo.CheckedChanged += cbAbrirArchivo_CheckedChanged;
            // 
            // FormCreacionReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 293);
            Controls.Add(cbAbrirArchivo);
            Controls.Add(cbFormato);
            Controls.Add(btnCrearReporte);
            Controls.Add(calPeriodo);
            Name = "FormCreacionReporte";
            Text = "Crear nuevo reporte";
            Load += FormCreacionReporte_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar calPeriodo;
        private Button btnCrearReporte;
        private ComboBox cbFormato;
        private CheckBox cbAbrirArchivo;
    }
}