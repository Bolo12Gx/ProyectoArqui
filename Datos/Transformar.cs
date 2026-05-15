namespace Datos
{
    public class Transformar
    {
        private int numero;



        public Transformar(int numero)
        {
            this.numero = numero;
        }
        public Transformar() { }
        // Método privado que centraliza la conversión a cualquier base
        private string ConvertirEnBase(int baseNum, bool usarHex = false)
        {
            if (numero == 0) return "0";

            if (numero < baseNum)
            {
                return usarHex ? numero.ToString("X") : numero.ToString();
            }

            int temp = numero;
            string resultado = "";

            while (temp > 0)
            {
                int residuo = temp % baseNum;
                int cociente = temp / baseNum;
                string digito = usarHex ? residuo.ToString("X") : residuo.ToString();
                resultado = digito + resultado;
                temp = cociente;
            }

            return resultado;
        }

        public string Binario()
        {
            return ConvertirEnBase(2);
        }

        public string Octal()
        {
            return ConvertirEnBase(8);
        }

        public string Hexadecimal()
        {
            return ConvertirEnBase(16, usarHex: true);
        }
    }
}
