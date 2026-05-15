namespace Conversiones
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
            label1 = new Label();
            label3 = new Label();
            lblResultado = new Label();
            txtNumero = new TextBox();
            cmbBase = new ComboBox();
            btnConvertir = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Número:";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 79);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "Base:";
            label3.Click += label3_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(12, 190);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(62, 15);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "Decimal: 0";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(96, 23);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 3;
            // 
            // cmbBase
            // 
            cmbBase.FormattingEnabled = true;
            cmbBase.Location = new Point(96, 71);
            cmbBase.Name = "cmbBase";
            cmbBase.Size = new Size(121, 23);
            cmbBase.TabIndex = 4;
            cmbBase.SelectedIndexChanged += cmbBase_SelectedIndexChanged;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(96, 123);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(100, 23);
            btnConvertir.TabIndex = 5;
            btnConvertir.Text = "CONVERTIR";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 164);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 6;
            label2.Text = "Resultado:";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnConvertir);
            Controls.Add(cmbBase);
            Controls.Add(txtNumero);
            Controls.Add(label3);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label lblResultado;
        private TextBox txtNumero;
        private ComboBox cmbBase;
        private Button btnConvertir;
        private Label label2;
    }
}
