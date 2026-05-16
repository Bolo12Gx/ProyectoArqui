using System.Drawing;
using System.Windows.Forms;

namespace Presentación
{
    partial class Menu
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
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fase1ToolStripMenuItem, fase2ToolStripMenuItem, fase3ToolStripMenuItem, fase4ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1756, 33);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fase1ToolStripMenuItem
            // 
            fase1ToolStripMenuItem.Name = "fase1ToolStripMenuItem";
            fase1ToolStripMenuItem.Size = new Size(77, 29);
            fase1ToolStripMenuItem.Text = "Fase 1";
            fase1ToolStripMenuItem.Click += fase1ToolStripMenuItem_Click;
            // 
            // fase2ToolStripMenuItem
            // 
            fase2ToolStripMenuItem.Name = "fase2ToolStripMenuItem";
            fase2ToolStripMenuItem.Size = new Size(77, 29);
            fase2ToolStripMenuItem.Text = "Fase 2";
            fase2ToolStripMenuItem.Click += fase2ToolStripMenuItem_Click;
            // 
            // fase3ToolStripMenuItem
            // 
            fase3ToolStripMenuItem.Name = "fase3ToolStripMenuItem";
            fase3ToolStripMenuItem.Size = new Size(82, 29);
            fase3ToolStripMenuItem.Text = "Fase 3 ";
            fase3ToolStripMenuItem.Click += fase3ToolStripMenuItem_Click;
            // 
            // fase4ToolStripMenuItem
            // 
            fase4ToolStripMenuItem.Name = "fase4ToolStripMenuItem";
            fase4ToolStripMenuItem.Size = new Size(77, 29);
            fase4ToolStripMenuItem.Text = "Fase 4";
            fase4ToolStripMenuItem.Click += fase4ToolStripMenuItem_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 33);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1756, 825);
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
