using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InserirNomesEmArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nomes = new string[5];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Insira um nome na posição {i + 1}: ");
                nomes[i] = Console.ReadLine();
            }
            Console.WriteLine("\n");

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Nome {i+1}: {nomes[i]}");
            }


        }
    }
}
