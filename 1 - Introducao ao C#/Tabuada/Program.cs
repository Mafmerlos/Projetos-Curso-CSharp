using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero que voce deseja a tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"A tabuada do {numero} é: ");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($" {numero} x {i} = {numero * i}");
            }
            Console.WriteLine("\nDigite um ENTER para encerrar o programa");
            Console.ReadLine();
        }
    }
}
