namespace Datos
{
    public class Transformar
    {
        private int numero;
        private int numeroTemp;

        // Constructor
        public Transformar(int numero)
        {
            this.numero = numero;
        }

        public string Binario()
        {
            numeroTemp = numero;
            string binario = "";

            if (numero == 0)
            {
                return "0";
            }

            while (numeroTemp > 0)
            {
                int residuo = numeroTemp % 2;
                int cociente = numeroTemp / 2;

                binario = residuo + binario;
                numeroTemp = cociente;
            }

            return binario;
        }

        public string Octal()
        {
            numeroTemp = numero;
            string octal = "";


            if (numero < 8)
            {
                return numero.ToString();
            }

            while (numeroTemp > 0)
            {
                int residuo = numeroTemp % 8;
                int cociente = numeroTemp / 8;

                octal = residuo + octal;
                numeroTemp = cociente;
            }

            return octal;
        }
        public string Hexadecimal()
        {
            numeroTemp = numero;
            string hexadecimal = "";
            if (numero < 16)
            {
                return numero.ToString("X");
            }
            while (numeroTemp > 0)
            {
                int residuo = numeroTemp % 16;
                int cociente = numeroTemp / 16;
                hexadecimal = residuo.ToString("X") + hexadecimal;
                numeroTemp = cociente;
            }
            return hexadecimal;
        }
    }
}
