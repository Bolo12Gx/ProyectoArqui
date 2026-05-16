using System;
using System.Windows.Forms;
using Datos;

namespace Presentación
{
    public partial class Menu : Form
    {
        private Form formularioActivo = null;
        public Menu()
        {
            InitializeComponent();
        }
        private void AbrirFormularioEnPanel(Form formHijo)
        {

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formHijo;


            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None; 
            formHijo.Dock = DockStyle.Fill; 


            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }
        private void fase1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Fase1Forms());
        }

        private void fase2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Fase2Forms());
        }

        private void fase3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Fase3Forms());
        }

        private void fase4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Fase4Forms());
        }
    }
}
