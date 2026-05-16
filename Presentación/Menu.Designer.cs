using System.Drawing;
using System.Windows.Forms;

namespace Presentación
{
    partial class Menu
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
            menuStrip1 = new MenuStrip();
            fase1ToolStripMenuItem = new ToolStripMenuItem();
            fase2ToolStripMenuItem = new ToolStripMenuItem();
            fase3ToolStripMenuItem = new ToolStripMenuItem();
            fase4ToolStripMenuItem = new ToolStripMenuItem();
            panelContenedor = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(15, 23, 42);
            menuStrip1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            menuStrip1.ForeColor = Color.White;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fase1ToolStripMenuItem, fase2ToolStripMenuItem, fase3ToolStripMenuItem, fase4ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(15, 10, 15, 10);
            menuStrip1.Size = new Size(1756, 54);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fase1ToolStripMenuItem
            // 
            fase1ToolStripMenuItem.ForeColor = Color.White;
            fase1ToolStripMenuItem.Name = "fase1ToolStripMenuItem";
            fase1ToolStripMenuItem.Size = new Size(86, 34);
            fase1ToolStripMenuItem.Text = "Fase 1";
            fase1ToolStripMenuItem.Click += fase1ToolStripMenuItem_Click;
            // 
            // fase2ToolStripMenuItem
            // 
            fase2ToolStripMenuItem.ForeColor = Color.White;
            fase2ToolStripMenuItem.Name = "fase2ToolStripMenuItem";
            fase2ToolStripMenuItem.Size = new Size(89, 34);
            fase2ToolStripMenuItem.Text = "Fase 2";
            fase2ToolStripMenuItem.Click += fase2ToolStripMenuItem_Click;
            // 
            // fase3ToolStripMenuItem
            // 
            fase3ToolStripMenuItem.ForeColor = Color.White;
            fase3ToolStripMenuItem.Name = "fase3ToolStripMenuItem";
            fase3ToolStripMenuItem.Size = new Size(89, 34);
            fase3ToolStripMenuItem.Text = "Fase 3";
            fase3ToolStripMenuItem.Click += fase3ToolStripMenuItem_Click;
            // 
            // fase4ToolStripMenuItem
            // 
            fase4ToolStripMenuItem.ForeColor = Color.White;
            fase4ToolStripMenuItem.Name = "fase4ToolStripMenuItem";
            fase4ToolStripMenuItem.Size = new Size(90, 34);
            fase4ToolStripMenuItem.Text = "Fase 4";
            fase4ToolStripMenuItem.Click += fase4ToolStripMenuItem_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 54);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1756, 804);
            panelContenedor.TabIndex = 5;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1756, 858);
            Controls.Add(panelContenedor);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10F);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fase1ToolStripMenuItem;
        private ToolStripMenuItem fase2ToolStripMenuItem;
        private ToolStripMenuItem fase3ToolStripMenuItem;
        private ToolStripMenuItem fase4ToolStripMenuItem;
        private Panel panelContenedor;
    }
}