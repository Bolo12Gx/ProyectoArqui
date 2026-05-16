namespace Presentación
{
    partial class Fase2Forms
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
            cmbBase = new ComboBox();
            lblSeleccionBase = new Label();
            lblResultadoConvertir = new Label();
            btnConvertir = new Button();
            txtNumeroConvertir = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbBase
            // 
            cmbBase.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBase.FlatStyle = FlatStyle.Flat;
            cmbBase.FormattingEnabled = true;
            cmbBase.Items.AddRange(new object[] { "Binario", "Octal", "Hexadecimal" });
            cmbBase.Location = new Point(735, 161);
            cmbBase.Name = "cmbBase";
            cmbBase.Size = new Size(200, 33);
            cmbBase.TabIndex = 18;
            // 
            // lblSeleccionBase
            // 
            lblSeleccionBase.AutoSize = true;
            lblSeleccionBase.ForeColor = Color.FromArgb(40, 40, 40);
            lblSeleccionBase.Location = new Point(337, 164);
            lblSeleccionBase.Name = "lblSeleccionBase";
            lblSeleccionBase.Size = new Size(154, 25);
            lblSeleccionBase.TabIndex = 17;
            lblSeleccionBase.Text = "Seleccione la base";
            // 
            // lblResultadoConvertir
            // 
            lblResultadoConvertir.BackColor = Color.WhiteSmoke;
            lblResultadoConvertir.BorderStyle = BorderStyle.FixedSingle;
            lblResultadoConvertir.ForeColor = Color.FromArgb(30, 30, 30);
            lblResultadoConvertir.Location = new Point(337, 356);
            lblResultadoConvertir.Name = "lblResultadoConvertir";
            lblResultadoConvertir.Padding = new Padding(9);
            lblResultadoConvertir.Size = new Size(722, 181);
            lblResultadoConvertir.TabIndex = 16;
            // 
            // btnConvertir
            // 
            btnConvertir.BackColor = Color.FromArgb(30, 144, 255);
            btnConvertir.Cursor = Cursors.Hand;
            btnConvertir.FlatAppearance.BorderSize = 0;
            btnConvertir.FlatStyle = FlatStyle.Flat;
            btnConvertir.ForeColor = Color.White;
            btnConvertir.Location = new Point(337, 256);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(123, 38);
            btnConvertir.TabIndex = 15;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = false;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // txtNumeroConvertir
            // 
            txtNumeroConvertir.BackColor = Color.White;
            txtNumeroConvertir.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroConvertir.Location = new Point(735, 206);
            txtNumeroConvertir.Name = "txtNumeroConvertir";
            txtNumeroConvertir.Size = new Size(200, 31);
            txtNumeroConvertir.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(40, 40, 40);
            label1.Location = new Point(337, 212);
            label1.Name = "label1";
            label1.Size = new Size(319, 25);
            label1.TabIndex = 13;
            label1.Text = "Ingrese número a convertir en decimal:";
            // 
            // Fase2Forms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1396, 700);
            Controls.Add(lblResultadoConvertir);
            Controls.Add(cmbBase);
            Controls.Add(lblSeleccionBase);
            Controls.Add(btnConvertir);
            Controls.Add(txtNumeroConvertir);
            Controls.Add(label1);
            Name = "Fase2Forms";
            Text = "Fase2Forms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBase;
        private Label lblSeleccionBase;
        private Label lblResultadoConvertir;
        private Button btnConvertir;
        private TextBox txtNumeroConvertir;
        private Label label1;
    }
}