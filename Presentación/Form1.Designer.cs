using System.Drawing;
using System.Windows.Forms;

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
            txtSumando1 = new TextBox();
            lblSumando1 = new Label();
            txtSumando2 = new TextBox();
            lblSumando2 = new Label();
            btnRestar = new Button();
            btnSumar = new Button();
            lblResultadoSumar = new Label();
            lblBits = new Label();
            txtNumeroBits = new TextBox();
            btnComplemento2 = new Button();
            btnRevertirC2 = new Button();
            lblResultadoC2 = new Label();
            lblProcesoC2 = new Label();
            txtNumbits = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnBinario
            // 
            btnBinario.BackColor = Color.FromArgb(30, 144, 255);
            btnBinario.Cursor = Cursors.Hand;
            btnBinario.FlatAppearance.BorderSize = 0;
            btnBinario.FlatStyle = FlatStyle.Flat;
            btnBinario.ForeColor = Color.White;
            btnBinario.Location = new Point(40, 121);
            btnBinario.Name = "btnBinario";
            btnBinario.Size = new Size(123, 38);
            btnBinario.TabIndex = 0;
            btnBinario.Text = "Binario";
            btnBinario.UseVisualStyleBackColor = false;
            btnBinario.Click += btnBinario_Click;
            // 
            // lblNumeroDecimal
            // 
            lblNumeroDecimal.AutoSize = true;
            lblNumeroDecimal.ForeColor = Color.FromArgb(40, 40, 40);
            lblNumeroDecimal.Location = new Point(40, 29);
            lblNumeroDecimal.Name = "lblNumeroDecimal";
            lblNumeroDecimal.Size = new Size(225, 28);
            lblNumeroDecimal.TabIndex = 1;
            lblNumeroDecimal.Text = "Ingrese número decimal:";
            // 
            // txtNumeroDecimal
            // 
            txtNumeroDecimal.BackColor = Color.White;
            txtNumeroDecimal.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroDecimal.Location = new Point(297, 26);
            txtNumeroDecimal.Name = "txtNumeroDecimal";
            txtNumeroDecimal.Size = new Size(165, 34);
            txtNumeroDecimal.TabIndex = 2;
            // 
            // lblResultado
            // 
            lblResultado.BackColor = Color.WhiteSmoke;
            lblResultado.BorderStyle = BorderStyle.FixedSingle;
            lblResultado.ForeColor = Color.FromArgb(30, 30, 30);
            lblResultado.Location = new Point(40, 224);
            lblResultado.Name = "lblResultado";
            lblResultado.Padding = new Padding(9, 9, 9, 9);
            lblResultado.Size = new Size(722, 181);
            lblResultado.TabIndex = 3;
            // 
            // btnOctal
            // 
            btnOctal.BackColor = Color.FromArgb(72, 201, 176);
            btnOctal.Cursor = Cursors.Hand;
            btnOctal.FlatAppearance.BorderSize = 0;
            btnOctal.FlatStyle = FlatStyle.Flat;
            btnOctal.ForeColor = Color.White;
            btnOctal.Location = new Point(201, 121);
            btnOctal.Name = "btnOctal";
            btnOctal.Size = new Size(123, 38);
            btnOctal.TabIndex = 4;
            btnOctal.Text = "Octal";
            btnOctal.UseVisualStyleBackColor = false;
            btnOctal.Click += btnOctal_Click;
            // 
            // btnHexadecimal
            // 
            btnHexadecimal.BackColor = Color.FromArgb(255, 140, 0);
            btnHexadecimal.Cursor = Cursors.Hand;
            btnHexadecimal.FlatAppearance.BorderSize = 0;
            btnHexadecimal.FlatStyle = FlatStyle.Flat;
            btnHexadecimal.ForeColor = Color.White;
            btnHexadecimal.Location = new Point(378, 121);
            btnHexadecimal.Name = "btnHexadecimal";
            btnHexadecimal.Size = new Size(156, 38);
            btnHexadecimal.TabIndex = 5;
            btnHexadecimal.Text = "Hexadecimal";
            btnHexadecimal.UseVisualStyleBackColor = false;
            btnHexadecimal.Click += btnHexadecimal_Click;
            // 
            // btnTodas
            // 
            btnTodas.BackColor = Color.FromArgb(123, 97, 255);
            btnTodas.Cursor = Cursors.Hand;
            btnTodas.FlatAppearance.BorderSize = 0;
            btnTodas.FlatStyle = FlatStyle.Flat;
            btnTodas.ForeColor = Color.White;
            btnTodas.Location = new Point(563, 121);
            btnTodas.Name = "btnTodas";
            btnTodas.Size = new Size(156, 38);
            btnTodas.TabIndex = 6;
            btnTodas.Text = "Todas las bases";
            btnTodas.UseVisualStyleBackColor = false;
            btnTodas.Click += btnTodas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(40, 40, 40);
            label1.Location = new Point(870, 77);
            label1.Name = "label1";
            label1.Size = new Size(349, 28);
            label1.TabIndex = 7;
            label1.Text = "Ingrese número a convertir en decimal:";
            // 
            // txtNumeroConvertir
            // 
            txtNumeroConvertir.BackColor = Color.White;
            txtNumeroConvertir.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroConvertir.Location = new Point(1268, 71);
            txtNumeroConvertir.Name = "txtNumeroConvertir";
            txtNumeroConvertir.Size = new Size(165, 34);
            txtNumeroConvertir.TabIndex = 8;
            // 
            // btnConvertir
            // 
            btnConvertir.BackColor = Color.FromArgb(30, 144, 255);
            btnConvertir.Cursor = Cursors.Hand;
            btnConvertir.FlatAppearance.BorderSize = 0;
            btnConvertir.FlatStyle = FlatStyle.Flat;
            btnConvertir.ForeColor = Color.White;
            btnConvertir.Location = new Point(870, 121);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(123, 38);
            btnConvertir.TabIndex = 9;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = false;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lblResultadoConvertir
            // 
            lblResultadoConvertir.BackColor = Color.WhiteSmoke;
            lblResultadoConvertir.BorderStyle = BorderStyle.FixedSingle;
            lblResultadoConvertir.ForeColor = Color.FromArgb(30, 30, 30);
            lblResultadoConvertir.Location = new Point(870, 224);
            lblResultadoConvertir.Name = "lblResultadoConvertir";
            lblResultadoConvertir.Padding = new Padding(9, 9, 9, 9);
            lblResultadoConvertir.Size = new Size(722, 181);
            lblResultadoConvertir.TabIndex = 10;
            // 
            // lblSeleccionBase
            // 
            lblSeleccionBase.AutoSize = true;
            lblSeleccionBase.ForeColor = Color.FromArgb(40, 40, 40);
            lblSeleccionBase.Location = new Point(870, 29);
            lblSeleccionBase.Name = "lblSeleccionBase";
            lblSeleccionBase.Size = new Size(169, 28);
            lblSeleccionBase.TabIndex = 11;
            lblSeleccionBase.Text = "Seleccione la base";
            // 
            // cmbBase
            // 
            cmbBase.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBase.FlatStyle = FlatStyle.Flat;
            cmbBase.FormattingEnabled = true;
            cmbBase.Items.AddRange(new object[] { "Binario", "Octal", "Hexadecimal" });
            cmbBase.Location = new Point(1268, 26);
            cmbBase.Name = "cmbBase";
            cmbBase.Size = new Size(200, 36);
            cmbBase.TabIndex = 12;
            // 
            // txtSumando1
            // 
            txtSumando1.BorderStyle = BorderStyle.FixedSingle;
            txtSumando1.Location = new Point(1125, 460);
            txtSumando1.Name = "txtSumando1";
            txtSumando1.Size = new Size(165, 34);
            txtSumando1.TabIndex = 14;
            // 
            // lblSumando1
            // 
            lblSumando1.AutoSize = true;
            lblSumando1.ForeColor = Color.FromArgb(40, 40, 40);
            lblSumando1.Location = new Point(868, 464);
            lblSumando1.Name = "lblSumando1";
            lblSumando1.Size = new Size(201, 28);
            lblSumando1.TabIndex = 13;
            lblSumando1.Text = "Ingrese el sumando 1:";
            // 
            // txtSumando2
            // 
            txtSumando2.BorderStyle = BorderStyle.FixedSingle;
            txtSumando2.Location = new Point(1125, 511);
            txtSumando2.Name = "txtSumando2";
            txtSumando2.Size = new Size(165, 34);
            txtSumando2.TabIndex = 16;
            // 
            // lblSumando2
            // 
            lblSumando2.AutoSize = true;
            lblSumando2.ForeColor = Color.FromArgb(40, 40, 40);
            lblSumando2.Location = new Point(868, 514);
            lblSumando2.Name = "lblSumando2";
            lblSumando2.Size = new Size(201, 28);
            lblSumando2.TabIndex = 15;
            lblSumando2.Text = "Ingrese el sumando 2:";
            // 
            // btnRestar
            // 
            btnRestar.BackColor = Color.FromArgb(220, 53, 69);
            btnRestar.FlatAppearance.BorderSize = 0;
            btnRestar.FlatStyle = FlatStyle.Flat;
            btnRestar.ForeColor = Color.White;
            btnRestar.Location = new Point(1030, 562);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(123, 38);
            btnRestar.TabIndex = 18;
            btnRestar.Text = "Restar";
            btnRestar.UseVisualStyleBackColor = false;
            // 
            // btnSumar
            // 
            btnSumar.BackColor = Color.FromArgb(40, 167, 69);
            btnSumar.Cursor = Cursors.Hand;
            btnSumar.FlatAppearance.BorderSize = 0;
            btnSumar.FlatStyle = FlatStyle.Flat;
            btnSumar.ForeColor = Color.White;
            btnSumar.Location = new Point(868, 562);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(123, 38);
            btnSumar.TabIndex = 17;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = false;
            btnSumar.Click += btnSumar_Click;
            // 
            // lblResultadoSumar
            // 
            lblResultadoSumar.BackColor = Color.WhiteSmoke;
            lblResultadoSumar.BorderStyle = BorderStyle.FixedSingle;
            lblResultadoSumar.ForeColor = Color.FromArgb(30, 30, 30);
            lblResultadoSumar.Location = new Point(868, 618);
            lblResultadoSumar.Name = "lblResultadoSumar";
            lblResultadoSumar.Padding = new Padding(9, 9, 9, 9);
            lblResultadoSumar.Size = new Size(722, 181);
            lblResultadoSumar.TabIndex = 19;
            // 
            // lblBits
            // 
            lblBits.AutoSize = true;
            lblBits.ForeColor = Color.FromArgb(40, 40, 40);
            lblBits.Location = new Point(44, 457);
            lblBits.Name = "lblBits";
            lblBits.Size = new Size(184, 28);
            lblBits.TabIndex = 20;
            lblBits.Text = "Número de bits (N):";
            // 
            // txtNumeroBits
            // 
            txtNumeroBits.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroBits.Location = new Point(308, 457);
            txtNumeroBits.Name = "txtNumeroBits";
            txtNumeroBits.Size = new Size(165, 34);
            txtNumeroBits.TabIndex = 21;
            txtNumeroBits.Text = "8";
            // 
            // btnComplemento2
            // 
            btnComplemento2.BackColor = Color.FromArgb(70, 130, 180);
            btnComplemento2.Cursor = Cursors.Hand;
            btnComplemento2.FlatAppearance.BorderSize = 0;
            btnComplemento2.FlatStyle = FlatStyle.Flat;
            btnComplemento2.ForeColor = Color.White;
            btnComplemento2.Location = new Point(40, 517);
            btnComplemento2.Name = "btnComplemento2";
            btnComplemento2.Size = new Size(220, 38);
            btnComplemento2.TabIndex = 22;
            btnComplemento2.Text = "Calcular Complemento a 2";
            btnComplemento2.UseVisualStyleBackColor = false;
            btnComplemento2.Click += btnComplemento2_Click;
            // 
            // btnRevertirC2
            // 
            btnRevertirC2.BackColor = Color.FromArgb(100, 149, 237);
            btnRevertirC2.Cursor = Cursors.Hand;
            btnRevertirC2.FlatAppearance.BorderSize = 0;
            btnRevertirC2.FlatStyle = FlatStyle.Flat;
            btnRevertirC2.ForeColor = Color.White;
            btnRevertirC2.Location = new Point(297, 517);
            btnRevertirC2.Name = "btnRevertirC2";
            btnRevertirC2.Size = new Size(220, 38);
            btnRevertirC2.TabIndex = 23;
            btnRevertirC2.Text = "Revertir Ca2 -> Decimal";
            btnRevertirC2.UseVisualStyleBackColor = false;
            btnRevertirC2.Click += btnRevertirC2_Click;
            // 
            // lblResultadoC2
            // 
            lblResultadoC2.BackColor = Color.White;
            lblResultadoC2.BorderStyle = BorderStyle.FixedSingle;
            lblResultadoC2.ForeColor = Color.FromArgb(30, 30, 30);
            lblResultadoC2.Location = new Point(44, 578);
            lblResultadoC2.Name = "lblResultadoC2";
            lblResultadoC2.Padding = new Padding(7, 7, 7, 7);
            lblResultadoC2.Size = new Size(660, 48);
            lblResultadoC2.TabIndex = 24;
            lblResultadoC2.Text = "Complemento a 2: ";
            // 
            // lblProcesoC2
            // 
            lblProcesoC2.BackColor = Color.WhiteSmoke;
            lblProcesoC2.BorderStyle = BorderStyle.FixedSingle;
            lblProcesoC2.ForeColor = Color.FromArgb(30, 30, 30);
            lblProcesoC2.Location = new Point(44, 626);
            lblProcesoC2.Name = "lblProcesoC2";
            lblProcesoC2.Padding = new Padding(9, 9, 9, 9);
            lblProcesoC2.Size = new Size(660, 89);
            lblProcesoC2.TabIndex = 25;
            lblProcesoC2.Text = "Proceso: ";
            // 
            // txtNumbits
            // 
            txtNumbits.BorderStyle = BorderStyle.FixedSingle;
            txtNumbits.Location = new Point(1125, 416);
            txtNumbits.Name = "txtNumbits";
            txtNumbits.Size = new Size(165, 34);
            txtNumbits.TabIndex = 27;
            txtNumbits.Text = "8";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(40, 40, 40);
            label2.Location = new Point(868, 416);
            label2.Name = "label2";
            label2.Size = new Size(184, 28);
            label2.TabIndex = 26;
            label2.Text = "Número de bits (N):";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1756, 858);
            Controls.Add(txtNumbits);
            Controls.Add(label2);
            Controls.Add(lblProcesoC2);
            Controls.Add(lblResultadoC2);
            Controls.Add(btnRevertirC2);
            Controls.Add(btnComplemento2);
            Controls.Add(txtNumeroBits);
            Controls.Add(lblBits);
            Controls.Add(lblResultadoSumar);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(txtSumando2);
            Controls.Add(lblSumando2);
            Controls.Add(txtSumando1);
            Controls.Add(lblSumando1);
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
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
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
        private TextBox txtSumando1;
        private Label lblSumando1;
        private TextBox txtSumando2;
        private Label lblSumando2;
        private Button btnRestar;
        private Button btnSumar;
        private Label lblResultadoSumar;

        // Nuevos controles para Fase 3
        private Label lblBits;
        private TextBox txtNumeroBits;
        private Button btnComplemento2;
        private Button btnRevertirC2;
        private Label lblResultadoC2;
        private Label lblProcesoC2;
        private TextBox txtNumbits;
        private Label label2;
    }
}
