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
    public partial class Fase3Forms : Form
    {
        public Fase3Forms()
        {
            InitializeComponent();
            lblResultadoC2.Text = "Complemento a 2: ";
            lblProcesoC2.Text = "Proceso: ";
        }
        private void btnComplemento2_Click(object sender, EventArgs e)
        {
            // lee número decimal (permite negativos) y N bits
            if (!int.TryParse(txtNumeroDecimal.Text.Trim(), out int numeroIngresado))
            {
                MessageBox.Show("Ingrese un número entero válido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string bitsText = txtNumeroBits.Text.Trim();
            if (!int.TryParse(bitsText, out int numeroBits) || numeroBits <= 0)
            {
                MessageBox.Show("Ingrese un número válido de bits (por ejemplo 8, 16, 32).", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var fase3 = new Fase3(numeroIngresado);
            string c2 = fase3.Complemento2(numeroBits.ToString());
            // extraer solo la parte binaria (evitar texto " ->[OVERFLOW]")
            string bin = ExtractBinary(c2);
            lblResultadoC2.Text = "Complemento a 2: " + bin;
            lblProcesoC2.Text = "Detalles: " + c2;
        }
        private string ExtractBinary(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            var outChars = new System.Text.StringBuilder();
            foreach (char c in s)
            {
                if (c == '0' || c == '1') outChars.Append(c);
                else if (outChars.Length > 0) break; // si ya empezamos a leer y aparece otra cosa, asumimos fin
            }
            return outChars.ToString();
        }
        private void btnRevertirC2_Click(object sender, EventArgs e)
        {
            // usar la cadena mostrada en lblResultadoC2 si existe, o pedir al usuario que ingrese una
            string texto = lblResultadoC2.Text.Replace("Complemento a 2:", "").Trim();
            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("No hay representación binaria disponible. Primero calcule el complemento a 2.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string bin = ExtractBinary(texto);
            if (!IsBinaryString(bin))
            {
                MessageBox.Show("La representación binaria no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //var fase3 = new Fase3(0);
            string proceso = Fase3.RevertirC2(bin);
            lblProcesoC2.Text = proceso;
        }
        private bool IsBinaryString(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            foreach (char c in s)
            {
                if (c != '0' && c != '1') return false;
            }
            return true;
        }
    }
}
