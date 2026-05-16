namespace Presentación
{
    partial class Fase2Forms
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            cmbBase = new ComboBox();
            lblSeleccionBase = new Label();
            lblResultadoConvertir = new Label();
            btnConvertir = new Button();
            txtNumeroConvertir = new TextBox();
            label1 = new Label();
            lblTittle = new Label();
            SuspendLayout();
            // 
            // cmbBase
            // 
            cmbBase.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBase.FlatStyle = FlatStyle.Flat;
            cmbBase.Font = new Font("Segoe UI", 11F);
            cmbBase.FormattingEnabled = true;
            cmbBase.Items.AddRange(new object[] { "Binario", "Octal", "Hexadecimal" });
            cmbBase.Location = new Point(387, 132);
            cmbBase.Name = "cmbBase";
            cmbBase.Size = new Size(250, 38);
            cmbBase.TabIndex = 12;
            // 
            // lblSeleccionBase
            // 
            lblSeleccionBase.AutoSize = true;
            lblSeleccionBase.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblSeleccionBase.ForeColor = Color.FromArgb(51, 65, 85);
            lblSeleccionBase.Location = new Point(67, 134);
            lblSeleccionBase.Name = "lblSeleccionBase";
            lblSeleccionBase.Size = new Size(217, 32);
            lblSeleccionBase.TabIndex = 11;
            lblSeleccionBase.Text = "Seleccione la base:";
            // 
            // lblResultadoConvertir
            // 
            lblResultadoConvertir.BackColor = Color.White;
            lblResultadoConvertir.BorderStyle = BorderStyle.FixedSingle;
            lblResultadoConvertir.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblResultadoConvertir.ForeColor = Color.FromArgb(15, 23, 42);
            lblResultadoConvertir.Location = new Point(67, 334);
            lblResultadoConvertir.Name = "lblResultadoConvertir";
            lblResultadoConvertir.Padding = new Padding(15);
            lblResultadoConvertir.Size = new Size(570, 150);
            lblResultadoConvertir.TabIndex = 10;
            // 
            // btnConvertir
            // 
            btnConvertir.BackColor = Color.FromArgb(37, 99, 235);
            btnConvertir.Cursor = Cursors.Hand;
            btnConvertir.FlatAppearance.BorderSize = 0;
            btnConvertir.FlatStyle = FlatStyle.Flat;
            btnConvertir.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnConvertir.ForeColor = Color.White;
            btnConvertir.Location = new Point(67, 264);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(160, 45);
            btnConvertir.TabIndex = 9;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = false;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // txtNumeroConvertir
            // 
            txtNumeroConvertir.BackColor = Color.White;
            txtNumeroConvertir.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroConvertir.Font = new Font("Segoe UI", 12F);
            txtNumeroConvertir.ForeColor = Color.FromArgb(15, 23, 42);
            txtNumeroConvertir.Location = new Point(387, 192);
            txtNumeroConvertir.Name = "txtNumeroConvertir";
            txtNumeroConvertir.Size = new Size(250, 39);
            txtNumeroConvertir.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(51, 65, 85);
            label1.Location = new Point(67, 194);
            label1.Name = "label1";
            label1.Size = new Size(318, 32);
            label1.TabIndex = 13;
            label1.Text = "Ingrese número a convertir:";
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTittle.Location = new Point(387, 9);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(669, 48);
            lblTittle.TabIndex = 15;
            lblTittle.Text = "Conversión de Otras Bases a Decimal";
            // 
            // Fase2Forms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1756, 809);
            Controls.Add(lblTittle);
            Controls.Add(lblResultadoConvertir);
            Controls.Add(cmbBase);
            Controls.Add(lblSeleccionBase);
            Controls.Add(btnConvertir);
            Controls.Add(txtNumeroConvertir);
            Controls.Add(label1);
            Name = "Fase2Forms";
            Text = "Fase 2 - Conversión Bases a Decimal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBase;
        private System.Windows.Forms.Label lblSeleccionBase;
        private System.Windows.Forms.Label lblResultadoConvertir;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.TextBox txtNumeroConvertir;
        private System.Windows.Forms.Label label1;
        private Label lblTittle;
    }
}