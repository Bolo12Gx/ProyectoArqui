using System;
using System.Windows.Forms;

namespace Conversiones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // CARGAR FORMULARIO
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBase.Items.Add("Binario");
            cmbBase.Items.Add("Octal");
            cmbBase.Items.Add("Hexadecimal");

            cmbBase.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbBase_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // BOTON CONVERTIR
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                string numero = txtNumero.Text.ToUpper();

                int resultado = 0;

                string opcion = cmbBase.SelectedItem?.ToString() ?? "";

                // BINARIO
                if (opcion == "Binario")
                {
                    resultado = ConvertirADecimal(numero, 2);
                }

                // OCTAL
                else if (opcion == "Octal")
                {
                    resultado = ConvertirADecimal(numero, 8);
                }

                // HEXADECIMAL
                else if (opcion == "Hexadecimal")
                {
                    resultado = ConvertirADecimal(numero, 16);
                }

                lblResultado.Text = "Decimal: " + resultado;
            }
            catch
            {
                MessageBox.Show("Ingrese un numero valido");
            }
        }

        // FUNCION GENERAL DE CONVERSION
        private int ConvertirADecimal(string numero, int baseNum)
        {
            int decimalFinal = 0;

            int potencia = 0;

            // RECORRER DE DERECHA A IZQUIERDA
            for (int i = numero.Length - 1; i >= 0; i--)
            {
                char digito = numero[i];

                int valor = 0;

                // SI ES NUMERO
                if (digito >= '0' && digito <= '9')
                {
                    valor = digito - '0';
                }

                // SI ES LETRA HEXADECIMAL
                else
                {
                    valor = digito - 'A' + 10;
                }

                decimalFinal += valor * (int)Math.Pow(baseNum, potencia);

                potencia++;
            }

            return decimalFinal;
        }
    }
}