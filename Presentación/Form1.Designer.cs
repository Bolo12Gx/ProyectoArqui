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
            label1 = new Label();
            txtNumeroConvertir = new TextBox();
            btnConvertir = new Button();
            lblResultadoConvertir = new Label();
            lblSeleccionBase = new Label();
            cmbBase = new ComboBox();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(791, 69);
            label1.Name = "label1";
            label1.Size = new Size(319, 25);
            label1.TabIndex = 7;
            label1.Text = "Ingrese número a convertir en decimal:";
            // 
            // txtNumeroConvertir
            // 
            txtNumeroConvertir.Location = new Point(1153, 63);
            txtNumeroConvertir.Name = "txtNumeroConvertir";
            txtNumeroConvertir.Size = new Size(150, 31);
            txtNumeroConvertir.TabIndex = 8;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(791, 108);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(112, 34);
            btnConvertir.TabIndex = 9;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lblResultadoConvertir
            // 
            lblResultadoConvertir.Location = new Point(791, 200);
            lblResultadoConvertir.Name = "lblResultadoConvertir";
            lblResultadoConvertir.Size = new Size(657, 162);
            lblResultadoConvertir.TabIndex = 10;
            // 
            // lblSeleccionBase
            // 
            lblSeleccionBase.AutoSize = true;
            lblSeleccionBase.Location = new Point(791, 26);
            lblSeleccionBase.Name = "lblSeleccionBase";
            lblSeleccionBase.Size = new Size(154, 25);
            lblSeleccionBase.TabIndex = 11;
            lblSeleccionBase.Text = "Seleccione la base";
            // 
            // cmbBase
            // 
            cmbBase.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBase.FormattingEnabled = true;
            cmbBase.Items.AddRange(new object[] { "Binario", "Octal", "Hexadecimal" });
            cmbBase.Location = new Point(1153, 23);
            cmbBase.Name = "cmbBase";
            cmbBase.Size = new Size(182, 33);
            cmbBase.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1876, 723);
            Controls.Add(cmbBase);
            Controls.Add(lblSeleccionBase);
            Controls.Add(lblResultadoConvertir);
            Controls.Add(btnConvertir);
            Controls.Add(txtNumeroConvertir);
            Controls.Add(label1);
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
        private Label label1;
        private TextBox txtNumeroConvertir;
        private Button btnConvertir;
        private Label lblResultadoConvertir;
        private Label lblSeleccionBase;
        private ComboBox cmbBase;
    }
}
