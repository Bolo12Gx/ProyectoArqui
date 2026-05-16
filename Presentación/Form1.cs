using System;
using System.Windows.Forms;
using Datos;

namespace Presentación
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Inicializaciones de UI mínimas
            if (cmbBase.Items.Count > 0) cmbBase.SelectedIndex = 0;
            lblResultado.Text = "";
            lblResultadoConvertir.Text = "";
            lblResultadoSumar.Text = "";
            lblResultadoC2.Text = "Complemento a 2: ";
            lblProcesoC2.Text = "Proceso: ";

            // Registrar el evento del botón Restar (no estaba asignado en el diseñador)
            btnRestar.Click += btnRestar_Click;
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            // Validación de entrada
            if (!int.TryParse(txtNumeroDecimal.Text.Trim(), out int numeroIngresado))
            {
                MessageBox.Show("Ingrese un número entero válido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var transformador = new Transformar(numeroIngresado);
            lblResultado.Text = $"Número binario: {transformador.Binario()}";
        }

        private void btnOctal_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumeroDecimal.Text.Trim(), out int numeroIngresado))
            {
                MessageBox.Show("Ingrese un número entero válido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var transformador = new Transformar(numeroIngresado);
            lblResultado.Text = $"Número octal: {transformador.Octal()}";
        }

        private void btnHexadecimal_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumeroDecimal.Text.Trim(), out int numeroIngresado))
            {
                MessageBox.Show("Ingrese un número entero válido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var transformador = new Transformar(numeroIngresado);
            lblResultado.Text = $"Número hexadecimal: {transformador.Hexadecimal()}";
        }

        private void btnTodas_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumeroDecimal.Text.Trim(), out int numeroIngresado))
            {
                MessageBox.Show("Ingrese un número entero válido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var transformador = new Transformar(numeroIngresado);
            lblResultado.Text = $"Número binario: {transformador.Binario()}\nNúmero octal: {transformador.Octal()}\nNúmero hexadecimal: {transformador.Hexadecimal()}";
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            string numero = txtNumeroConvertir.Text.Trim().ToUpper();
            if (string.IsNullOrEmpty(numero))
            {
                MessageBox.Show("Ingrese un número para convertir.", "Entrada vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string opcion = cmbBase.SelectedItem?.ToString() ?? "";

            try
            {
                int resultado = 0;

                if (opcion == "Binario")
                {
                    resultado = new Fase2().ConvertirADecimal(numero, 2);
                }
                else if (opcion == "Octal")
                {
                    resultado = new Fase2().ConvertirADecimal(numero, 8);
                }
                else if (opcion == "Hexadecimal")
                {
                    resultado = new Fase2().ConvertirADecimal(numero, 16);
                }
                lblResultadoConvertir.Text = "Decimal: " + resultado;
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un número válido para la base seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            lblResultadoSumar.Text = "Suma: " + resultado + (overflow ? "  -> [OVERFLOW ARITMÉTICO]" : "");
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

            lblResultadoSumar.Text = "Resta: " + resultado + (overflow ? "  -> [OVERFLOW ARITMÉTICO]" : "");
        }

        // BOTONES PARA FASE 3 (Complemento a 2 y reversión)
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

        // Helpers mínimos para la UI

        // Verifica que la cadena solo contenga '0' y '1' y no esté vacía
        private bool IsBinaryString(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            foreach (char c in s)
            {
                if (c != '0' && c != '1') return false;
            }
            return true;
        }

        /*private void NormalizeBinaryLengths(ref string a, ref string b)
        {
            int n = Math.Max(a.Length, b.Length);
            a = a.PadLeft(n, '0');
            b = b.PadLeft(n, '0');
        }*/

        // Extrae la subsecuencia de 0/1 más larga de una cadena (útil para quitar sufijos como " ->[OVERFLOW]")
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
    }
}
