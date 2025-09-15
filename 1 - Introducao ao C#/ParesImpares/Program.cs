using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Imprimir todos numeros pares entre 0 e 300.
 * Imprimir todos numeros ímpares entre 0 e 300.
 */

namespace ParesImpares
{

    internal class Program
    {
        const int NUMEROMAXIMO = 300, NUMEROMINIMO = 1;
        static void Main(string[] args) {

            Console.WriteLine("Numeros Pares entre 0 e 300: ");
            for (int i = NUMEROMINIMO; i <= NUMEROMAXIMO; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);   
                }      
            }
            
            Console.WriteLine("Numeros Impares entre 0 e 300: ");
            for (int i = NUMEROMINIMO; i <= NUMEROMAXIMO; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Pressione ENTER para encerrar o programa");
            Console.ReadLine();

        }
    }
}
