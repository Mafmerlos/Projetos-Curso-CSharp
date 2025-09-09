using System;


namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número que voce deseja a tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            /*
                Resolvendo exericio da forma que foi ensinado até agora
            Console.WriteLine($"{numero} x {1} = {numero * 1}");
            Console.WriteLine($"{numero} x {2} = {numero * 2}");
            Console.WriteLine($"{numero} x {3} = {numero * 3}");
            Console.WriteLine($"{numero} x {4} = {numero * 4}");
            Console.WriteLine($"{numero} x {5} = {numero * 5}");
            Console.WriteLine($"{numero} x {6} = {numero * 6}");
            Console.WriteLine($"{numero} x {7} = {numero * 7}");
            Console.WriteLine($"{numero} x {8} = {numero * 8}");
            Console.WriteLine($"{numero} x {9} = {numero * 9}");
            Console.WriteLine($"{numero} x {10} = {numero * 10}");
            */

           // Resolvendo problema usando laços de repetição:
              Console.WriteLine($"A tabuada do {numero} é: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($" {numero} x {i} = {numero * i}");
            }

            Console.WriteLine("\nDigite um ENTER para encerrar o programa");
            Console.ReadLine();
        }
    }
}
