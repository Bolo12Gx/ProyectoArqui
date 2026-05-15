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

        public string Complemento2(string numeroBits)
        {
            int numeroC = int.Parse(numeroBits);
            numeroTemp = numero;

            if (numero == 0)
            {
                return "0".PadLeft(numeroC, '0');
            }

            else if (numero < 0)
            {
                numeroTemp = Math.Abs(numero);
                //Transforma el absoluto
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
                return SumaBinaria(Complemento1(binario, numeroC), "1");
            }
            else
            {
                string binarioPositivo = Binario().PadLeft(numeroC, '0');
                if (binarioPositivo[0] == '1')
                {
                    return binarioPositivo + " ->[OVERFLOW]";
                }
                return binarioPositivo;
            }
        }

        public string Complemento1(string binario, int numeroC)
        {
            binario = binario.PadLeft(numeroC, '0');
            char[] C1 = binario.ToCharArray();
            for (int i = 0; i < C1.Length; i++)
            {
                C1[i] = (C1[i] == '0') ? '1' : '0';
            }
            return new string(C1);
        }
        public string SumaBinaria(string binario1, string binario2)
        {
            int acarreo = 0;
            int longitudMaxima = Math.Max(binario1.Length, binario2.Length);

            binario1 = binario1.PadLeft(longitudMaxima, '0');
            binario2 = binario2.PadLeft(longitudMaxima, '0');

            char[] Sumando1 = binario1.ToCharArray();
            char[] Sumando2 = binario2.ToCharArray();
            char[] Resultado = new char[longitudMaxima];

            for (int i = longitudMaxima - 1; i >= 0; i--)
            {
                int bit1 = (Sumando1[i] == '1') ? 1 : 0;
                int bit2 = (Sumando2[i] == '1') ? 1 : 0;

                int sumaTotal = bit1 + bit2 + acarreo;

                int bitResultado = sumaTotal % 2;

                Resultado[i] = (bitResultado == 1) ? '1' : '0';
                acarreo = sumaTotal / 2;
            }
            
            string resultado = new string(Resultado);
            if (Resultado[0] == '0')
            {
                return resultado + " -> [OVERFLOW]";
            }

            return resultado;
        }

        public string RevertirC2(string binarioC2)
        {
            int tamano = binarioC2.Length;
            int resultadoDecimal = 0;
            string proceso = "Proceso: ";

            char[] binarioC2t = binarioC2.ToCharArray();
            int pesoMSB = (int)Math.Pow(2,tamano - 1);
            if(binarioC2t[0] == '1')
            {
                resultadoDecimal = - pesoMSB;
                proceso += " - " + pesoMSB;
            }
            else
            {
                resultadoDecimal = 0;
                proceso += " 0 ";
            }

            for(int i = 1; i < tamano; i++)
            {
                if (binarioC2t[i] == '1')
                {
                    int exponente = tamano-1-i;
                    int PesoPosicional = (int)Math.Pow(2,exponente);

                    resultadoDecimal += PesoPosicional;
                    proceso += " + " + PesoPosicional;
                } 
            }
            return proceso + " = " + resultadoDecimal;
        }
    }
}
