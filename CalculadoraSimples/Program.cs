using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero: ");
            int n2 = int.Parse(Console.ReadLine());

            //Operações aritméticos

            Console.WriteLine($"Soma: {n1 + n2}");
            Console.WriteLine($"Subtração: {n1 - n2}");
            Console.WriteLine($"Multiplicação: {n1 * n2}");
            Console.WriteLine($"Divisão: { (double) n1 / n2}"); //cast
            Console.WriteLine($"Resto: {n1%n2}");



        }
    }
}
