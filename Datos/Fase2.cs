using System;

namespace Datos
{
    public class Fase2
    {
        public int ConvertirADecimal(string numero, int baseNum)
        {
            int decimalFinal = 0;
            int potencia = 0;

            numero = numero.ToUpper();

            for (int i = numero.Length - 1; i >= 0; i--)
            {
                char digito = numero[i];
                int valor;

                // NUMEROS
                if (digito >= '0' && digito <= '9')
                {
                    valor = digito - '0';
                }

                // LETRAS HEXADECIMALES
                else if (digito >= 'A' && digito <= 'F')
                {
                    valor = digito - 'A' + 10;
                }

                // CARACTER INVALIDO
                else
                {
                    throw new Exception("Número inválido");
                }

                // VALIDAR SEGÚN LA BASE
                if (valor >= baseNum)
                {
                    throw new Exception("El número no pertenece a la base seleccionada");
                }

                decimalFinal += valor * (int)Math.Pow(baseNum, potencia);

                potencia++;
            }

            return decimalFinal;
        }
    }
}