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
            int numeroIngresado = int.Parse(txtNumeroDecimal.Text);
            Transformar minumero = new Transformar(numeroIngresado);
            lblResultado.Text = $"Número binario: {minumero.Binario()}";
        }

        private void btnOctal_Click(object sender, EventArgs e)
        {
            int numeroIngresado = int.Parse(txtNumeroDecimal.Text);
            Transformar minumero = new Transformar(numeroIngresado);
            lblResultado.Text = $"Número octal: {minumero.Octal()}";
        }

        private void btnHexadecimal_Click(object sender, EventArgs e)
        {
            int numeroIngresado = int.Parse(txtNumeroDecimal.Text);
            Transformar minumero = new Transformar(numeroIngresado);
            lblResultado.Text = $"Número hexadecimal: {minumero.Hexadecimal()}";
        }
    }
}
