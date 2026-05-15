using System;

namespace Datos
{
    public class Fase3
    {
        int numero;
        int numeroTemp;
        string numeroBits;
        public Fase3(int numero)
        {
            this.numero = numero;
        }

        // Método auxiliar para convertir un entero positivo a binario (sin signo)
        private string ConvertirPositivoABinario(int value)
        {
            if (value == 0) return "0";

            string binario = "";
            int temp = value;
            while (temp > 0)
            {
                int residuo = temp % 2;
                int cociente = temp / 2;

                binario = residuo + binario;
                temp = cociente;
            }
            return binario;
        }

        public string Binario()
        {
            numeroTemp = numero;
            return ConvertirPositivoABinario(numero);
        }

        // Devuelve la representación en complemento a dos de 'this.numero' usando 'numeroBits' bits (numeroBits como cadena que contiene el número de bits)
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
                // Para números negativos: obtener |numero| en binario, luego complemento a uno y sumar 1
                int absValue = Math.Abs(numero);
                string binario = ConvertirPositivoABinario(absValue).PadLeft(numeroC, '0');
                string c1 = Complemento1(binario, numeroC);
                // sumar 1 al complemento a uno para obtener complemento a dos
                return SumaBinaria(c1, "1");
            }
            else
            {
                string binarioPositivo = ConvertirPositivoABinario(numero).PadLeft(numeroC, '0');
                // Si el valor positivo no cabe (el bit más significativo es 1) se considera overflow según la regla de N bits
                if (binarioPositivo.Length > numeroC)
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

        // Suma binaria simple (sin señalización de overflow extra). Si hay acarreo fuera del MSB se ignora (comportamiento wrap-around típico en Ca2).
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

            // Ignoramos el acarreo final: wrap-around en complemento a dos
            return new string(Resultado);
        }

        public string RevertirC2(string binarioC2)
        {
            int tamano = binarioC2.Length;
            int resultadoDecimal = 0;
            string proceso = "Proceso: ";

            char[] binarioC2t = binarioC2.ToCharArray();
            int pesoMSB = (int)Math.Pow(2, tamano - 1);
            if (binarioC2t[0] == '1')
            {
                resultadoDecimal = -pesoMSB;
                proceso += " - " + pesoMSB;
            }
            else
            {
                resultadoDecimal = 0;
                proceso += " 0 ";
            }

            for (int i = 1; i < tamano; i++)
            {
                if (binarioC2t[i] == '1')
                {
                    int exponente = tamano - 1 - i;
                    int PesoPosicional = (int)Math.Pow(2, exponente);

                    resultadoDecimal += PesoPosicional;
                    proceso += " + " + PesoPosicional;
                }
            }
            return proceso + " = " + resultadoDecimal;
        }
    }
}
