namespace Presentación
{
    partial class Fase4Forms
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
            txtNumbits = new TextBox();
            label2 = new Label();
            lblResultadoSumar = new Label();
            btnRestar = new Button();
            btnSumar = new Button();
            txtSumando2 = new TextBox();
            lblSumando2 = new Label();
            txtSumando1 = new TextBox();
            lblSumando1 = new Label();
            lblTittle = new Label();
            SuspendLayout();
            // 
            // txtNumbits
            // 
            txtNumbits.BackColor = Color.White;
            txtNumbits.BorderStyle = BorderStyle.FixedSingle;
            txtNumbits.Font = new Font("Segoe UI", 11F);
            txtNumbits.ForeColor = Color.FromArgb(15, 23, 42);
            txtNumbits.Location = new Point(284, 116);
            txtNumbits.Name = "txtNumbits";
            txtNumbits.Size = new Size(200, 37);
            txtNumbits.TabIndex = 27;
            txtNumbits.Text = "8";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(51, 65, 85);
            label2.Location = new Point(54, 118);
            label2.Name = "label2";
            label2.Size = new Size(210, 30);
            label2.TabIndex = 26;
            label2.Text = "Número de bits (N):";
            // 
            // lblResultadoSumar
            // 
            lblResultadoSumar.BackColor = Color.White;
            lblResultadoSumar.BorderStyle = BorderStyle.FixedSingle;
            lblResultadoSumar.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblResultadoSumar.ForeColor = Color.FromArgb(15, 23, 42);
            lblResultadoSumar.Location = new Point(54, 368);
            lblResultadoSumar.Name = "lblResultadoSumar";
            lblResultadoSumar.Padding = new Padding(15);
            lblResultadoSumar.Size = new Size(650, 160);
            lblResultadoSumar.TabIndex = 19;
            // 
            // btnRestar
            // 
            btnRestar.BackColor = Color.FromArgb(239, 68, 68);
            btnRestar.Cursor = Cursors.Hand;
            btnRestar.FlatAppearance.BorderSize = 0;
            btnRestar.FlatStyle = FlatStyle.Flat;
            btnRestar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnRestar.ForeColor = Color.White;
            btnRestar.Location = new Point(214, 298);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(140, 45);
            btnRestar.TabIndex = 18;
            btnRestar.Text = "Restar";
            btnRestar.UseVisualStyleBackColor = false;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnSumar
            // 
            btnSumar.BackColor = Color.FromArgb(34, 197, 94);
            btnSumar.Cursor = Cursors.Hand;
            btnSumar.FlatAppearance.BorderSize = 0;
            btnSumar.FlatStyle = FlatStyle.Flat;
            btnSumar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnSumar.ForeColor = Color.White;
            btnSumar.Location = new Point(54, 298);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(140, 45);
            btnSumar.TabIndex = 17;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = false;
            btnSumar.Click += btnSumar_Click;
            // 
            // txtSumando2
            // 
            txtSumando2.BackColor = Color.White;
            txtSumando2.BorderStyle = BorderStyle.FixedSingle;
            txtSumando2.Font = new Font("Segoe UI", 11F);
            txtSumando2.ForeColor = Color.FromArgb(15, 23, 42);
            txtSumando2.Location = new Point(284, 236);
            txtSumando2.Name = "txtSumando2";
            txtSumando2.Size = new Size(200, 37);
            txtSumando2.TabIndex = 16;
            // 
            // lblSumando2
            // 
            lblSumando2.AutoSize = true;
            lblSumando2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblSumando2.ForeColor = Color.FromArgb(51, 65, 85);
            lblSumando2.Location = new Point(54, 238);
            lblSumando2.Name = "lblSumando2";
            lblSumando2.Size = new Size(230, 30);
            lblSumando2.TabIndex = 15;
            lblSumando2.Text = "Ingrese el sumando 2:";
            // 
            // txtSumando1
            // 
            txtSumando1.BackColor = Color.White;
            txtSumando1.BorderStyle = BorderStyle.FixedSingle;
            txtSumando1.Font = new Font("Segoe UI", 11F);
            txtSumando1.ForeColor = Color.FromArgb(15, 23, 42);
            txtSumando1.Location = new Point(284, 176);
            txtSumando1.Name = "txtSumando1";
            txtSumando1.Size = new Size(200, 37);
            txtSumando1.TabIndex = 14;
            // 
            // lblSumando1
            // 
            lblSumando1.AutoSize = true;
            lblSumando1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblSumando1.ForeColor = Color.FromArgb(51, 65, 85);
            lblSumando1.Location = new Point(54, 178);
            lblSumando1.Name = "lblSumando1";
            lblSumando1.Size = new Size(227, 30);
            lblSumando1.TabIndex = 28;
            lblSumando1.Text = "Ingrese el sumando 1:";
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTittle.Location = new Point(427, 9);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(797, 48);
            lblTittle.TabIndex = 29;
            lblTittle.Text = "Suma y Resta en binario (Complemento a 2)";
            // 
            // Fase4Forms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1756, 809);
            Controls.Add(lblTittle);
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
            Text = "Fase 4 - Suma y Resta Binaria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNumbits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultadoSumar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.TextBox txtSumando2;
        private System.Windows.Forms.Label lblSumando2;
        private System.Windows.Forms.TextBox txtSumando1;
        private System.Windows.Forms.Label lblSumando1;
        private Label lblTittle;
    }
}