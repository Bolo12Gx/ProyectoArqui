using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Fase2
    {
        public int ConvertirADecimal(string numero, int baseNum)
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
