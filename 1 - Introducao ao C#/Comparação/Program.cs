using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comparação");

            Console.WriteLine("Digite um numero");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 > n2) Console.WriteLine($"O numero {n1} é maior que o {n2}");
            else if (n1 < n2) Console.WriteLine($"O numero {n2} é maior que o {n1}");
            else Console.WriteLine("Os numero digitados são iguais");





        }
    }
}
