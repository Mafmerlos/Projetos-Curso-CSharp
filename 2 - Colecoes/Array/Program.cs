using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int numeroBlocos = 4;

            int[] n = new int[numeroBlocos];

            for (int i = 0; i < numeroBlocos; i++)
            {
                Console.WriteLine($"índice {i} => {n[i]}");
            }

            char[] palavra = { 'j', 'o', 'c', 'a' };

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"índice {i} => {palavra[i]}");
            }

            //Programa soletrando
            Console.Write("Entre com a palavra:");
            string palavra1 = Console.ReadLine();

            for (int i = 0; i < palavra1.Length; i++)
            {
                Console.WriteLine(palavra1[i]);
            }

            for (int i = palavra1.Length - 1; i > -1; i--) //escrever inversamente
            {
                Console.WriteLine(palavra1[i]);
            }
        }
    }
}
