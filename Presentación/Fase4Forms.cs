using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public partial class Fase4Forms : Form
    {
        public Fase4Forms()
        {
            InitializeComponent();
            lblResultadoSumar.Text = "";
        }
        private void btnSumar_Click(object sender, EventArgs e)
        {
            string sumando1 = txtSumando1.Text.Trim();
            string sumando2 = txtSumando2.Text.Trim();

            if (!IsBinaryString(sumando1) || !IsBinaryString(sumando2))
            {
                MessageBox.Show("Los sumandos deben ser cadenas binarias (solo 0 y 1).", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // leer N bits
            if (!int.TryParse(txtNumbits.Text.Trim(), out int numeroBits) || numeroBits <= 0)
            {
                MessageBox.Show("Ingrese un número válido de bits (por ejemplo 8, 16, 32).", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            sumando1 = sumando1.PadLeft(numeroBits, '0');
            sumando2 = sumando2.PadLeft(numeroBits, '0');

            var fase4 = new Fase4();
            var (resultado, overflow) = fase4.SumarBinarioComplement2(sumando1, sumando2, numeroBits);

            lblResultadoSumar.Text = "Suma: " + resultado + (overflow ? "  -> [OVERFLOW ]" : "");
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            string minuendo = txtSumando1.Text.Trim();
            string sustraendo = txtSumando2.Text.Trim();

            if (!IsBinaryString(minuendo) || !IsBinaryString(sustraendo))
            {
                MessageBox.Show("Los operandos deben ser cadenas binarias (solo 0 y 1).", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtNumbits.Text.Trim(), out int numeroBits) || numeroBits <= 0)
            {
                MessageBox.Show("Ingrese un número válido de bits (por ejemplo 8, 16, 32).", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            minuendo = minuendo.PadLeft(numeroBits, '0');
            sustraendo = sustraendo.PadLeft(numeroBits, '0');

            var fase4 = new Fase4();
            var (resultado, overflow) = fase4.RestarBinarioComplement2(minuendo, sustraendo, numeroBits);

            lblResultadoSumar.Text = "Resta: " + resultado + (overflow ? "  -> [OVERFLOW]" : "");
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
