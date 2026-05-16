namespace Presentación
{
    partial class Fase4Forms
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
            txtNumbits = new TextBox();
            label2 = new Label();
            lblResultadoSumar = new Label();
            btnRestar = new Button();
            btnSumar = new Button();
            txtSumando2 = new TextBox();
            lblSumando2 = new Label();
            txtSumando1 = new TextBox();
            lblSumando1 = new Label();
            SuspendLayout();
            // 
            // txtNumbits
            // 
            txtNumbits.BorderStyle = BorderStyle.FixedSingle;
            txtNumbits.Location = new Point(626, 165);
            txtNumbits.Name = "txtNumbits";
            txtNumbits.Size = new Size(165, 31);
            txtNumbits.TabIndex = 36;
            txtNumbits.Text = "8";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(40, 40, 40);
            label2.Location = new Point(369, 165);
            label2.Name = "label2";
            label2.Size = new Size(168, 25);
            label2.TabIndex = 35;
            label2.Text = "Número de bits (N):";
            // 
            // lblResultadoSumar
            // 
            lblResultadoSumar.BackColor = Color.WhiteSmoke;
            lblResultadoSumar.BorderStyle = BorderStyle.FixedSingle;
            lblResultadoSumar.ForeColor = Color.FromArgb(30, 30, 30);
            lblResultadoSumar.Location = new Point(369, 367);
            lblResultadoSumar.Name = "lblResultadoSumar";
            lblResultadoSumar.Padding = new Padding(9);
            lblResultadoSumar.Size = new Size(722, 181);
            lblResultadoSumar.TabIndex = 34;
            // 
            // btnRestar
            // 
            btnRestar.BackColor = Color.FromArgb(220, 53, 69);
            btnRestar.FlatAppearance.BorderSize = 0;
            btnRestar.FlatStyle = FlatStyle.Flat;
            btnRestar.ForeColor = Color.White;
            btnRestar.Location = new Point(531, 311);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(123, 38);
            btnRestar.TabIndex = 33;
            btnRestar.Text = "Restar";
            btnRestar.UseVisualStyleBackColor = false;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnSumar
            // 
            btnSumar.BackColor = Color.FromArgb(40, 167, 69);
            btnSumar.Cursor = Cursors.Hand;
            btnSumar.FlatAppearance.BorderSize = 0;
            btnSumar.FlatStyle = FlatStyle.Flat;
            btnSumar.ForeColor = Color.White;
            btnSumar.Location = new Point(369, 311);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(123, 38);
            btnSumar.TabIndex = 32;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = false;
            btnSumar.Click += btnSumar_Click;
            // 
            // txtSumando2
            // 
            txtSumando2.BorderStyle = BorderStyle.FixedSingle;
            txtSumando2.Location = new Point(626, 260);
            txtSumando2.Name = "txtSumando2";
            txtSumando2.Size = new Size(165, 31);
            txtSumando2.TabIndex = 31;
            // 
            // lblSumando2
            // 
            lblSumando2.AutoSize = true;
            lblSumando2.ForeColor = Color.FromArgb(40, 40, 40);
            lblSumando2.Location = new Point(369, 263);
            lblSumando2.Name = "lblSumando2";
            lblSumando2.Size = new Size(187, 25);
            lblSumando2.TabIndex = 30;
            lblSumando2.Text = "Ingrese el sumando 2:";
            // 
            // txtSumando1
            // 
            txtSumando1.BorderStyle = BorderStyle.FixedSingle;
            txtSumando1.Location = new Point(626, 209);
            txtSumando1.Name = "txtSumando1";
            txtSumando1.Size = new Size(165, 31);
            txtSumando1.TabIndex = 29;
            // 
            // lblSumando1
            // 
            lblSumando1.AutoSize = true;
            lblSumando1.ForeColor = Color.FromArgb(40, 40, 40);
            lblSumando1.Location = new Point(369, 213);
            lblSumando1.Name = "lblSumando1";
            lblSumando1.Size = new Size(187, 25);
            lblSumando1.TabIndex = 28;
            lblSumando1.Text = "Ingrese el sumando 1:";
            // 
            // Fase4Forms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1460, 712);
            Controls.Add(txtNumbits);
            Controls.Add(label2);
            Controls.Add(lblResultadoSumar);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(txtSumando2);
            Controls.Add(lblSumando2);
            Controls.Add(txtSumando1);
            Controls.Add(lblSumando1);
            Name = "Fase4Forms";
            Text = "Fase4Forms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumbits;
        private Label label2;
        private Label lblResultadoSumar;
        private Button btnRestar;
        private Button btnSumar;
        private TextBox txtSumando2;
        private Label lblSumando2;
        private TextBox txtSumando1;
        private Label lblSumando1;
    }
}