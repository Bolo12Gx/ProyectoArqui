namespace Presentación
{
    partial class Fase3Forms
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
            lblProcesoC2 = new Label();
            lblResultadoC2 = new Label();
            btnRevertirC2 = new Button();
            btnComplemento2 = new Button();
            txtNumeroBits = new TextBox();
            lblBits = new Label();
            txtNumeroDecimal = new TextBox();
            lblNumeroDecimal = new Label();
            SuspendLayout();
            // 
            // lblProcesoC2
            // 
            lblProcesoC2.BackColor = Color.WhiteSmoke;
            lblProcesoC2.BorderStyle = BorderStyle.FixedSingle;
            lblProcesoC2.ForeColor = Color.FromArgb(30, 30, 30);
            lblProcesoC2.Location = new Point(367, 395);
            lblProcesoC2.Name = "lblProcesoC2";
            lblProcesoC2.Padding = new Padding(9);
            lblProcesoC2.Size = new Size(660, 89);
            lblProcesoC2.TabIndex = 31;
            lblProcesoC2.Text = "Proceso: ";
            // 
            // lblResultadoC2
            // 
            lblResultadoC2.BackColor = Color.White;
            lblResultadoC2.BorderStyle = BorderStyle.FixedSingle;
            lblResultadoC2.ForeColor = Color.FromArgb(30, 30, 30);
            lblResultadoC2.Location = new Point(367, 347);
            lblResultadoC2.Name = "lblResultadoC2";
            lblResultadoC2.Padding = new Padding(7);
            lblResultadoC2.Size = new Size(660, 48);
            lblResultadoC2.TabIndex = 30;
            lblResultadoC2.Text = "Complemento a 2: ";
            // 
            // btnRevertirC2
            // 
            btnRevertirC2.BackColor = Color.FromArgb(100, 149, 237);
            btnRevertirC2.Cursor = Cursors.Hand;
            btnRevertirC2.FlatAppearance.BorderSize = 0;
            btnRevertirC2.FlatStyle = FlatStyle.Flat;
            btnRevertirC2.ForeColor = Color.White;
            btnRevertirC2.Location = new Point(620, 286);
            btnRevertirC2.Name = "btnRevertirC2";
            btnRevertirC2.Size = new Size(220, 38);
            btnRevertirC2.TabIndex = 29;
            btnRevertirC2.Text = "Revertir Ca2 -> Decimal";
            btnRevertirC2.UseVisualStyleBackColor = false;
            btnRevertirC2.Click += btnRevertirC2_Click;
            // 
            // btnComplemento2
            // 
            btnComplemento2.BackColor = Color.FromArgb(70, 130, 180);
            btnComplemento2.Cursor = Cursors.Hand;
            btnComplemento2.FlatAppearance.BorderSize = 0;
            btnComplemento2.FlatStyle = FlatStyle.Flat;
            btnComplemento2.ForeColor = Color.White;
            btnComplemento2.Location = new Point(363, 286);
            btnComplemento2.Name = "btnComplemento2";
            btnComplemento2.Size = new Size(220, 38);
            btnComplemento2.TabIndex = 28;
            btnComplemento2.Text = "Calcular Complemento a 2";
            btnComplemento2.UseVisualStyleBackColor = false;
            btnComplemento2.Click += btnComplemento2_Click;
            // 
            // txtNumeroBits
            // 
            txtNumeroBits.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroBits.Location = new Point(631, 226);
            txtNumeroBits.Name = "txtNumeroBits";
            txtNumeroBits.Size = new Size(165, 31);
            txtNumeroBits.TabIndex = 27;
            txtNumeroBits.Text = "8";
            // 
            // lblBits
            // 
            lblBits.AutoSize = true;
            lblBits.ForeColor = Color.FromArgb(40, 40, 40);
            lblBits.Location = new Point(367, 226);
            lblBits.Name = "lblBits";
            lblBits.Size = new Size(168, 25);
            lblBits.TabIndex = 26;
            lblBits.Text = "Número de bits (N):";
            // 
            // txtNumeroDecimal
            // 
            txtNumeroDecimal.BackColor = Color.White;
            txtNumeroDecimal.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroDecimal.Location = new Point(631, 188);
            txtNumeroDecimal.Name = "txtNumeroDecimal";
            txtNumeroDecimal.Size = new Size(165, 31);
            txtNumeroDecimal.TabIndex = 33;
            // 
            // lblNumeroDecimal
            // 
            lblNumeroDecimal.AutoSize = true;
            lblNumeroDecimal.ForeColor = Color.FromArgb(40, 40, 40);
            lblNumeroDecimal.Location = new Point(367, 190);
            lblNumeroDecimal.Name = "lblNumeroDecimal";
            lblNumeroDecimal.Size = new Size(207, 25);
            lblNumeroDecimal.TabIndex = 32;
            lblNumeroDecimal.Text = "Ingrese número decimal:";
            // 
            // Fase3Forms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1390, 710);
            Controls.Add(txtNumeroDecimal);
            Controls.Add(lblNumeroDecimal);
            Controls.Add(lblProcesoC2);
            Controls.Add(lblResultadoC2);
            Controls.Add(btnRevertirC2);
            Controls.Add(btnComplemento2);
            Controls.Add(txtNumeroBits);
            Controls.Add(lblBits);
            Name = "Fase3Forms";
            Text = "Fase3Forms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProcesoC2;
        private Label lblResultadoC2;
        private Button btnRevertirC2;
        private Button btnComplemento2;
        private TextBox txtNumeroBits;
        private Label lblBits;
        private TextBox txtNumeroDecimal;
        private Label lblNumeroDecimal;
    }
}