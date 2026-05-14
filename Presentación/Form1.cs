using Datos;
namespace Presentación
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
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

                // BINARIO
                if (opcion == "Binario")
                {
                    resultado = new Fase2().ConvertirADecimal(numero, 2);
                }

                // OCTAL
                else if (opcion == "Octal")
                {
                    resultado = new Fase2().ConvertirADecimal(numero, 2);
                }

                // HEXADECIMAL
                else if (opcion == "Hexadecimal")
                {
                    resultado = new Fase2().ConvertirADecimal(numero, 2);
                }

                lblResultadoConvertir.Text = "Decimal: " + resultado;
            }
            catch
            {
                MessageBox.Show("Ingrese un numero valido");
            }
        }
    }
}
