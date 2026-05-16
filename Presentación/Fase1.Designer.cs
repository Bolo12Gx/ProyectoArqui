namespace Presentación
{
    partial class Fase1
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
            btnTodas = new Button();
            btnHexadecimal = new Button();
            btnOctal = new Button();
            lblResultado = new Label();
            txtNumeroDecimal = new TextBox();
            lblNumeroDecimal = new Label();
            btnBinario = new Button();
            SuspendLayout();
            // 
            // btnTodas
            // 
            btnTodas.BackColor = Color.FromArgb(123, 97, 255);
            btnTodas.Cursor = Cursors.Hand;
            btnTodas.FlatAppearance.BorderSize = 0;
            btnTodas.FlatStyle = FlatStyle.Flat;
            btnTodas.ForeColor = Color.White;
            btnTodas.Location = new Point(583, 189);
            btnTodas.Name = "btnTodas";
            btnTodas.Size = new Size(156, 38);
            btnTodas.TabIndex = 13;
            btnTodas.Text = "Todas las bases";
            btnTodas.UseVisualStyleBackColor = false;
            // 
            // btnHexadecimal
            // 
            btnHexadecimal.BackColor = Color.FromArgb(255, 140, 0);
            btnHexadecimal.Cursor = Cursors.Hand;
            btnHexadecimal.FlatAppearance.BorderSize = 0;
            btnHexadecimal.FlatStyle = FlatStyle.Flat;
            btnHexadecimal.ForeColor = Color.White;
            btnHexadecimal.Location = new Point(398, 189);
            btnHexadecimal.Name = "btnHexadecimal";
            btnHexadecimal.Size = new Size(156, 38);
            btnHexadecimal.TabIndex = 12;
            btnHexadecimal.Text = "Hexadecimal";
            btnHexadecimal.UseVisualStyleBackColor = false;
            // 
            // btnOctal
            // 
            btnOctal.BackColor = Color.FromArgb(72, 201, 176);
            btnOctal.Cursor = Cursors.Hand;
            btnOctal.FlatAppearance.BorderSize = 0;
            btnOctal.FlatStyle = FlatStyle.Flat;
            btnOctal.ForeColor = Color.White;
            btnOctal.Location = new Point(221, 189);
            btnOctal.Name = "btnOctal";
            btnOctal.Size = new Size(123, 38);
            btnOctal.TabIndex = 11;
            btnOctal.Text = "Octal";
            btnOctal.UseVisualStyleBackColor = false;
            // 
            // lblResultado
            // 
            lblResultado.BackColor = Color.WhiteSmoke;
            lblResultado.BorderStyle = BorderStyle.FixedSingle;
            lblResultado.ForeColor = Color.FromArgb(30, 30, 30);
            lblResultado.Location = new Point(60, 292);
            lblResultado.Name = "lblResultado";
            lblResultado.Padding = new Padding(9);
            lblResultado.Size = new Size(722, 181);
            lblResultado.TabIndex = 10;
            // 
            // txtNumeroDecimal
            // 
            txtNumeroDecimal.BackColor = Color.White;
            txtNumeroDecimal.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroDecimal.Location = new Point(317, 94);
            txtNumeroDecimal.Name = "txtNumeroDecimal";
            txtNumeroDecimal.Size = new Size(165, 31);
            txtNumeroDecimal.TabIndex = 9;
            // 
            // lblNumeroDecimal
            // 
            lblNumeroDecimal.AutoSize = true;
            lblNumeroDecimal.ForeColor = Color.FromArgb(40, 40, 40);
            lblNumeroDecimal.Location = new Point(60, 97);
            lblNumeroDecimal.Name = "lblNumeroDecimal";
            lblNumeroDecimal.Size = new Size(207, 25);
            lblNumeroDecimal.TabIndex = 8;
            lblNumeroDecimal.Text = "Ingrese número decimal:";
            // 
            // btnBinario
            // 
            btnBinario.BackColor = Color.FromArgb(30, 144, 255);
            btnBinario.Cursor = Cursors.Hand;
            btnBinario.FlatAppearance.BorderSize = 0;
            btnBinario.FlatStyle = FlatStyle.Flat;
            btnBinario.ForeColor = Color.White;
            btnBinario.Location = new Point(60, 189);
            btnBinario.Name = "btnBinario";
            btnBinario.Size = new Size(123, 38);
            btnBinario.TabIndex = 7;
            btnBinario.Text = "Binario";
            btnBinario.UseVisualStyleBackColor = false;
            // 
            // Fase1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1749, 681);
            Controls.Add(btnTodas);
            Controls.Add(btnHexadecimal);
            Controls.Add(btnOctal);
            Controls.Add(lblResultado);
            Controls.Add(txtNumeroDecimal);
            Controls.Add(lblNumeroDecimal);
            Controls.Add(btnBinario);
            Name = "Fase1";
            Text = "Fase1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTodas;
        private Button btnHexadecimal;
        private Button btnOctal;
        private Label lblResultado;
        private TextBox txtNumeroDecimal;
        private Label lblNumeroDecimal;
        private Button btnBinario;
    }
}