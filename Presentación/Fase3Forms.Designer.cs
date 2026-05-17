namespace Presentación
{
    partial class Fase3Forms
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
            lblProcesoC2 = new Label();
            lblResultadoC2 = new Label();
            btnRevertirC2 = new Button();
            btnComplemento2 = new Button();
            txtNumeroBits = new TextBox();
            lblBits = new Label();
            txtNumeroDecimal = new TextBox();
            lblNumeroDecimal = new Label();
            lblTittle = new Label();
            SuspendLayout();
            // 
            // lblProcesoC2
            // 
            lblProcesoC2.BackColor = Color.White;
            lblProcesoC2.BorderStyle = BorderStyle.FixedSingle;
            lblProcesoC2.Font = new Font("Segoe UI", 11F);
            lblProcesoC2.ForeColor = Color.FromArgb(51, 65, 85);
            lblProcesoC2.Location = new Point(580, 420);
            lblProcesoC2.Name = "lblProcesoC2";
            lblProcesoC2.Padding = new Padding(15);
            lblProcesoC2.Size = new Size(650, 150);
            lblProcesoC2.TabIndex = 25;
            lblProcesoC2.Text = "Detalles: ";
            // 
            // lblResultadoC2
            // 
            lblResultadoC2.BackColor = Color.White;
            lblResultadoC2.BorderStyle = BorderStyle.FixedSingle;
            lblResultadoC2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblResultadoC2.ForeColor = Color.FromArgb(15, 23, 42);
            lblResultadoC2.Location = new Point(580, 325);
            lblResultadoC2.Name = "lblResultadoC2";
            lblResultadoC2.Padding = new Padding(10);
            lblResultadoC2.Size = new Size(650, 65);
            lblResultadoC2.TabIndex = 24;
            lblResultadoC2.Text = "Complemento a 2: ";
            // 
            // btnRevertirC2
            // 
            btnRevertirC2.BackColor = Color.FromArgb(13, 148, 136);
            btnRevertirC2.Cursor = Cursors.Hand;
            btnRevertirC2.FlatAppearance.BorderSize = 0;
            btnRevertirC2.FlatStyle = FlatStyle.Flat;
            btnRevertirC2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnRevertirC2.ForeColor = Color.White;
            btnRevertirC2.Location = new Point(600, 255);
            btnRevertirC2.Name = "btnRevertirC2";
            btnRevertirC2.Size = new Size(300, 45);
            btnRevertirC2.TabIndex = 23;
            btnRevertirC2.Text = "Revertir C2 -> Decimal";
            btnRevertirC2.UseVisualStyleBackColor = false;
            btnRevertirC2.Click += btnRevertirC2_Click;
            // 
            // btnComplemento2
            // 
            btnComplemento2.BackColor = Color.FromArgb(37, 99, 235);
            btnComplemento2.Cursor = Cursors.Hand;
            btnComplemento2.FlatAppearance.BorderSize = 0;
            btnComplemento2.FlatStyle = FlatStyle.Flat;
            btnComplemento2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnComplemento2.ForeColor = Color.White;
            btnComplemento2.Location = new Point(1000, 255); //
            btnComplemento2.Name = "btnComplemento2";
            btnComplemento2.Size = new Size(230, 45);
            btnComplemento2.TabIndex = 22;
            btnComplemento2.Text = "Calcular C2";
            btnComplemento2.UseVisualStyleBackColor = false;
            btnComplemento2.Click += btnComplemento2_Click;
            // 
            // txtNumeroBits
            // 
            txtNumeroBits.BackColor = Color.White;
            txtNumeroBits.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroBits.Font = new Font("Segoe UI", 11F);
            txtNumeroBits.ForeColor = Color.FromArgb(15, 23, 42);
            txtNumeroBits.Location = new Point(980, 188);
            txtNumeroBits.Name = "txtNumeroBits";
            txtNumeroBits.Size = new Size(200, 37);
            txtNumeroBits.TabIndex = 21;
            txtNumeroBits.Text = "8";
            // 
            // lblBits
            // 
            lblBits.AutoSize = true;
            lblBits.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblBits.ForeColor = Color.FromArgb(51, 65, 85);
            lblBits.Location = new Point(650, 190);
            lblBits.Name = "lblBits";
            lblBits.Size = new Size(210, 30);
            lblBits.TabIndex = 20;
            lblBits.Text = "Número de bits (N):";
            // 
            // txtNumeroDecimal
            // 
            txtNumeroDecimal.BackColor = Color.White;
            txtNumeroDecimal.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroDecimal.Font = new Font("Segoe UI", 11F);
            txtNumeroDecimal.ForeColor = Color.FromArgb(15, 23, 42);
            txtNumeroDecimal.Location = new Point(980, 128); //
            txtNumeroDecimal.Name = "txtNumeroDecimal";
            txtNumeroDecimal.Size = new Size(200, 37);
            txtNumeroDecimal.TabIndex = 33;
            // 
            // lblNumeroDecimal
            // 
            lblNumeroDecimal.AutoSize = true;
            lblNumeroDecimal.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblNumeroDecimal.ForeColor = Color.FromArgb(51, 65, 85);
            lblNumeroDecimal.Location = new Point(600, 130); //
            lblNumeroDecimal.Name = "lblNumeroDecimal";
            lblNumeroDecimal.Size = new Size(300, 30);
            lblNumeroDecimal.TabIndex = 32;
            lblNumeroDecimal.Text = "Ingrese número decimal:";
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTittle.Location = new Point(520, 9);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(740, 48);
            lblTittle.TabIndex = 34;
            lblTittle.Text = "Aritmética Binaria y Complemento a Dos";
            // 
            // Fase3Forms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1756, 809);
            Controls.Add(lblTittle);
            Controls.Add(txtNumeroDecimal);
            Controls.Add(lblNumeroDecimal);
            Controls.Add(lblProcesoC2);
            Controls.Add(lblResultadoC2);
            Controls.Add(btnRevertirC2);
            Controls.Add(btnComplemento2);
            Controls.Add(txtNumeroBits);
            Controls.Add(lblBits);
            Name = "Fase3Forms";
            Text = "Fase 3 - Complemento a 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblProcesoC2;
        private System.Windows.Forms.Label lblResultadoC2;
        private System.Windows.Forms.Button btnRevertirC2;
        private System.Windows.Forms.Button btnComplemento2;
        private System.Windows.Forms.TextBox txtNumeroBits;
        private System.Windows.Forms.Label lblBits;
        private System.Windows.Forms.TextBox txtNumeroDecimal;
        private System.Windows.Forms.Label lblNumeroDecimal;
        private Label lblTittle;
    }
}