using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
namespace Presentación
{
    public partial class Fase1Forms : Form
    {
        public Fase1Forms()
        {
            InitializeComponent();
            lblResultado.Text = "";
        }
        private void btnBinario_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumeroDecimal.Text.Trim(), out int numeroIngresado))
            {
                MessageBox.Show("Ingrese un número entero válido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var transformador = new Fase1(numeroIngresado);
            lblResultado.Text = $"Número binario: {transformador.Binario()}";
        }
        private void btnOctal_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumeroDecimal.Text.Trim(), out int numeroIngresado))
            {
                MessageBox.Show("Ingrese un número entero válido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var transformador = new Fase1(numeroIngresado);
            lblResultado.Text = $"Número octal: {transformador.Octal()}";
        }
        private void btnHexadecimal_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumeroDecimal.Text.Trim(), out int numeroIngresado))
            {
                MessageBox.Show("Ingrese un número entero válido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var transformador = new Fase1(numeroIngresado);
            lblResultado.Text = $"Número hexadecimal: {transformador.Hexadecimal()}";
        }

        private void btnTodas_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumeroDecimal.Text.Trim(), out int numeroIngresado))
            {
                MessageBox.Show("Ingrese un número entero válido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var transformador = new Fase1(numeroIngresado);
            lblResultado.Text = $"Número binario: {transformador.Binario()}\nNúmero octal: {transformador.Octal()}\nNúmero hexadecimal: {transformador.Hexadecimal()}";
        }
    }
}
