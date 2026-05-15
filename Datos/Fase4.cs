using System;

namespace Datos
{
    public class Fase4
    {
        public Fase4() { }

        // Alinea dos cadenas binarias al mismo tamaño (pad left con ceros)
        private void Normalize(ref string a, ref string b)
        {
            int n = Math.Max(a.Length, b.Length);
            a = a.PadLeft(n, '0');
            b = b.PadLeft(n, '0');
        }

        // Normaliza o recorta a un ancho de bits específico (mantiene los bits menos significativos si hay exceso)
        private void NormalizeToWidth(ref string s, int width)
        {
            if (s.Length > width) s = s.Substring(s.Length - width);
            else s = s.PadLeft(width, '0');
        }

        public (string resultado, bool overflow) SumarBinarioComplement2(string sumando1, string sumando2, int bitWidth)
        {
            if (sumando1 is null) throw new ArgumentNullException(nameof(sumando1));
            if (sumando2 is null) throw new ArgumentNullException(nameof(sumando2));
            if (bitWidth <= 0) throw new ArgumentOutOfRangeException(nameof(bitWidth), "El número de bits debe ser positivo.");

            sumando1 = sumando1.Trim();
            sumando2 = sumando2.Trim();

            // Ajustar a la anchura indicada (recortar si es necesario)
            NormalizeToWidth(ref sumando1, bitWidth);
            NormalizeToWidth(ref sumando2, bitWidth);

            int n = bitWidth;
            char[] resultado = new char[n];
            int acarreo = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                int bit1 = sumando1[i] - '0';
                int bit2 = sumando2[i] - '0';
                int suma = bit1 + bit2 + acarreo;
                resultado[i] = (char)((suma % 2) + '0');
                acarreo = suma / 2;
            }

            // Detección de overflow en complemento a dos:
            // overflow ocurre si los signos de los operandos son iguales y difieren del signo del resultado
            bool sign1 = sumando1[0] == '1';
            bool sign2 = sumando2[0] == '1';
            bool signRes = resultado[0] == '1';
            bool overflow = (sign1 == sign2) && (signRes != sign1);

            return (new string(resultado), overflow);
        }

        // Sobrecarga para compatibilidad: calcula usando el ancho máximo de los operandos (comportamiento previo)
        public string SumarBinarioComplement2(string sumando1, string sumando2)
        {
            int bitWidth = Math.Max(sumando1?.Trim().Length ?? 0, sumando2?.Trim().Length ?? 0);
            if (bitWidth == 0) return "";
            var (res, _) = SumarBinarioComplement2(sumando1, sumando2, bitWidth);
            return res;
        }


        public (string resultado, bool overflow) RestarBinarioComplement2(string minuendo, string sustraendo, int bitWidth)
        {
            if (minuendo is null) throw new ArgumentNullException(nameof(minuendo));
            if (sustraendo is null) throw new ArgumentNullException(nameof(sustraendo));
            if (bitWidth <= 0) throw new ArgumentOutOfRangeException(nameof(bitWidth), "El número de bits debe ser positivo.");

            minuendo = minuendo.Trim();
            sustraendo = sustraendo.Trim();

            NormalizeToWidth(ref minuendo, bitWidth);
            NormalizeToWidth(ref sustraendo, bitWidth);

            // Obtener complemento a dos del sustraendo: invertir y sumar 1
            string invertido = InvertBits(sustraendo);
            string uno = "1".PadLeft(bitWidth, '0');
            var (complemento2Sustraendo, _) = SumarBinarioComplement2(invertido, uno, bitWidth);

            // Sumar y calcular overflow según regla de complemento a dos
            var (resultado, overflow) = SumarBinarioComplement2(minuendo, complemento2Sustraendo, bitWidth);
            return (resultado, overflow);
        }

        // Sobrecarga para compatibilidad
        public string RestarBinarioComplement2(string minuendo, string sustraendo)
        {
            int bitWidth = Math.Max(minuendo?.Trim().Length ?? 0, sustraendo?.Trim().Length ?? 0);
            if (bitWidth == 0) return "";
            var (res, _) = RestarBinarioComplement2(minuendo, sustraendo, bitWidth);
            return res;
        }

        private string InvertBits(string binario)
        {
            char[] arr = binario.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (arr[i] == '0') ? '1' : '0';
            }
            return new string(arr);
        }
    }
}