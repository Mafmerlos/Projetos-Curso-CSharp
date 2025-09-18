using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParImpar
{
    internal class Program
    {
        const int QTDNUMEROS = 15;
        static void Main(string[] args)
        {
            int[] pares = new int[QTDNUMEROS];
            int[] impares = new int[QTDNUMEROS];
            int numero = 0, contadorPar = 0, contadorImpar = 0;


            for (int i = 0; i < QTDNUMEROS; i++)
            {
                Console.Write($"Digite o numero {i}: ");
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    pares[contadorPar++] = numero;

                }
                else
                {
                    impares[contadorImpar++] = numero;

                }
            }

            for (int i = 0; i < contadorPar; i++)
            {
                Console.Write(pares[i]);
            }

            Console.WriteLine("\n");

            for (int i = 0; i < contadorImpar; i++)
            {
                Console.Write(impares[i]);

            }


        }
    }
}
