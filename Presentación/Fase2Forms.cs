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
    public partial class Fase2Forms : Form
    {
        public Fase2Forms()
        {
            InitializeComponent();
            if (cmbBase.Items.Count > 0) cmbBase.SelectedIndex = 0;

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
    }
}
