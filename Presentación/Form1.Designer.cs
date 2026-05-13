namespace Presentación
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBinario = new Button();
            lblNumeroDecimal = new Label();
            txtNumeroDecimal = new TextBox();
            lblResultado = new Label();
            btnOctal = new Button();
            btnHexadecimal = new Button();
            btnTodas = new Button();
            SuspendLayout();
            // 
            // btnBinario
            // 
            btnBinario.Location = new Point(36, 108);
            btnBinario.Name = "btnBinario";
            btnBinario.Size = new Size(112, 34);
            btnBinario.TabIndex = 0;
            btnBinario.Text = "Binario";
            btnBinario.UseVisualStyleBackColor = true;
            btnBinario.Click += btnBinario_Click;
            // 
            // lblNumeroDecimal
            // 
            lblNumeroDecimal.AutoSize = true;
            lblNumeroDecimal.Location = new Point(36, 26);
            lblNumeroDecimal.Name = "lblNumeroDecimal";
            lblNumeroDecimal.Size = new Size(207, 25);
            lblNumeroDecimal.TabIndex = 1;
            lblNumeroDecimal.Text = "Ingrese número decimal:";
            // 
            // txtNumeroDecimal
            // 
            txtNumeroDecimal.Location = new Point(270, 23);
            txtNumeroDecimal.Name = "txtNumeroDecimal";
            txtNumeroDecimal.Size = new Size(150, 31);
            txtNumeroDecimal.TabIndex = 2;
            // 
            // lblResultado
            // 
            lblResultado.Location = new Point(36, 200);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(657, 162);
            lblResultado.TabIndex = 3;
            // 
            // btnOctal
            // 
            btnOctal.Location = new Point(183, 108);
            btnOctal.Name = "btnOctal";
            btnOctal.Size = new Size(112, 34);
            btnOctal.TabIndex = 4;
            btnOctal.Text = "Octal";
            btnOctal.UseVisualStyleBackColor = true;
            btnOctal.Click += btnOctal_Click;
            // 
            // btnHexadecimal
            // 
            btnHexadecimal.Location = new Point(344, 108);
            btnHexadecimal.Name = "btnHexadecimal";
            btnHexadecimal.Size = new Size(142, 34);
            btnHexadecimal.TabIndex = 5;
            btnHexadecimal.Text = "Hexadecimal";
            btnHexadecimal.UseVisualStyleBackColor = true;
            btnHexadecimal.Click += btnHexadecimal_Click;
            // 
            // btnTodas
            // 
            btnTodas.Location = new Point(512, 108);
            btnTodas.Name = "btnTodas";
            btnTodas.Size = new Size(142, 34);
            btnTodas.TabIndex = 6;
            btnTodas.Text = "Todas las bases";
            btnTodas.UseVisualStyleBackColor = true;
            btnTodas.Click += btnTodas_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTodas);
            Controls.Add(btnHexadecimal);
            Controls.Add(btnOctal);
            Controls.Add(lblResultado);
            Controls.Add(txtNumeroDecimal);
            Controls.Add(lblNumeroDecimal);
            Controls.Add(btnBinario);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBinario;
        private Label lblNumeroDecimal;
        private TextBox txtNumeroDecimal;
        private Label lblResultado;
        private Button btnOctal;
        private Button btnHexadecimal;
        private Button btnTodas;
    }
}
