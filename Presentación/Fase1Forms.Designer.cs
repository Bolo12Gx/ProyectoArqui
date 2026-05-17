namespace Presentación
{
    partial class Fase1Forms
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
            btnTodas = new Button();
            btnHexadecimal = new Button();
            btnOctal = new Button();
            lblResultado = new Label();
            txtNumeroDecimal = new TextBox();
            lblNumeroDecimal = new Label();
            btnBinario = new Button();
            lblTittle = new Label();
            SuspendLayout();
            // 
            // btnTodas
            // 
            btnTodas.BackColor = Color.FromArgb(124, 58, 237);
            btnTodas.Cursor = Cursors.Hand;
            btnTodas.FlatAppearance.BorderSize = 0;
            btnTodas.FlatStyle = FlatStyle.Flat;
            btnTodas.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnTodas.ForeColor = Color.White;
            btnTodas.Location = new Point(1200, 201); //
            btnTodas.Name = "btnTodas";
            btnTodas.Size = new Size(240, 45); //
            btnTodas.TabIndex = 6;
            btnTodas.Text = "Todas las bases";
            btnTodas.UseVisualStyleBackColor = false;
            btnTodas.Click += btnTodas_Click;
            // 
            // btnHexadecimal
            // 
            btnHexadecimal.BackColor = Color.FromArgb(217, 119, 6);
            btnHexadecimal.Cursor = Cursors.Hand;
            btnHexadecimal.FlatAppearance.BorderSize = 0;
            btnHexadecimal.FlatStyle = FlatStyle.Flat;
            btnHexadecimal.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnHexadecimal.ForeColor = Color.White;
            btnHexadecimal.Location = new Point(900, 201);
            btnHexadecimal.Name = "btnHexadecimal";
            btnHexadecimal.Size = new Size(240, 45);
            btnHexadecimal.TabIndex = 5;
            btnHexadecimal.Text = "Hexadecimal";
            btnHexadecimal.UseVisualStyleBackColor = false;
            btnHexadecimal.Click += btnHexadecimal_Click;
            // 
            // btnOctal
            // 
            btnOctal.BackColor = Color.FromArgb(13, 148, 136);
            btnOctal.Cursor = Cursors.Hand;
            btnOctal.FlatAppearance.BorderSize = 0;
            btnOctal.FlatStyle = FlatStyle.Flat;
            btnOctal.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnOctal.ForeColor = Color.White;
            btnOctal.Location = new Point(600, 201);
            btnOctal.Name = "btnOctal";
            btnOctal.Size = new Size(240, 45);
            btnOctal.TabIndex = 4;
            btnOctal.Text = "Octal";
            btnOctal.UseVisualStyleBackColor = false;
            btnOctal.Click += btnOctal_Click;
            // 
            // lblResultado
            // 
            lblResultado.BackColor = Color.White;
            lblResultado.BorderStyle = BorderStyle.FixedSingle;
            lblResultado.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblResultado.ForeColor = Color.FromArgb(15, 23, 42);
            lblResultado.Location = new Point(500, 300);
            lblResultado.Name = "lblResultado";
            lblResultado.Padding = new Padding(15);
            lblResultado.Size = new Size(680, 180);
            lblResultado.TabIndex = 3;
            // 
            // txtNumeroDecimal
            // 
            txtNumeroDecimal.BackColor = Color.White;
            txtNumeroDecimal.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroDecimal.Font = new Font("Segoe UI", 12F);
            txtNumeroDecimal.ForeColor = Color.FromArgb(15, 23, 42);
            txtNumeroDecimal.Location = new Point(800, 119);
            txtNumeroDecimal.Name = "txtNumeroDecimal";
            txtNumeroDecimal.Size = new Size(300, 39);
            txtNumeroDecimal.TabIndex = 2;
            // 
            // lblNumeroDecimal
            // 
            lblNumeroDecimal.AutoSize = true;
            lblNumeroDecimal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblNumeroDecimal.ForeColor = Color.FromArgb(51, 65, 85);
            lblNumeroDecimal.Location = new Point(400, 121);
            lblNumeroDecimal.Name = "lblNumeroDecimal";
            lblNumeroDecimal.Size = new Size(283, 32);
            lblNumeroDecimal.TabIndex = 1;
            lblNumeroDecimal.Text = "Ingrese número decimal:";
            // 
            // btnBinario
            // 
            btnBinario.BackColor = Color.FromArgb(37, 99, 235);
            btnBinario.Cursor = Cursors.Hand;
            btnBinario.FlatAppearance.BorderSize = 0;
            btnBinario.FlatStyle = FlatStyle.Flat;
            btnBinario.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnBinario.ForeColor = Color.White;
            btnBinario.Location = new Point(300, 201);
            btnBinario.Name = "btnBinario";
            btnBinario.Size = new Size(240, 45);
            btnBinario.TabIndex = 0;
            btnBinario.Text = "Binario";
            btnBinario.UseVisualStyleBackColor = false;
            btnBinario.Click += btnBinario_Click;
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTittle.Location = new Point(450, 9);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(798, 48);
            lblTittle.TabIndex = 7;
            lblTittle.Text = "Conversiones de Base Decimal a Otras Bases";
            // 
            // Fase1Forms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1756, 809);
            Controls.Add(lblTittle);
            Controls.Add(btnTodas);
            Controls.Add(btnHexadecimal);
            Controls.Add(btnOctal);
            Controls.Add(lblResultado);
            Controls.Add(txtNumeroDecimal);
            Controls.Add(lblNumeroDecimal);
            Controls.Add(btnBinario);
            Name = "Fase1Forms";
            Text = "Fase 1 - Conversión Decimal a Bases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnTodas;
        private System.Windows.Forms.Button btnHexadecimal;
        private System.Windows.Forms.Button btnOctal;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtNumeroDecimal;
        private System.Windows.Forms.Label lblNumeroDecimal;
        private System.Windows.Forms.Button btnBinario;
        private Label lblTittle;
    }
}