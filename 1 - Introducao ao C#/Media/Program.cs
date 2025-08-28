using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Solicite 3 notas para o usuário e calcule a média final das notas 
 * Média: Somar as notas e dividir por 3
 */

// Sempre que tiver um erro no programa realizar um DEBUG linha a linha antes de procurar ajuda

namespace Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira nota:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            double n2 = double.Parse(Console.ReadLine());
                 
            Console.WriteLine("Digite a terceita nota:");
            double n3 = double.Parse(Console.ReadLine());

            double media = (n1 + n2 + n3) / 3;
            
            Console.WriteLine($"Média: {media}");

            Console.WriteLine("Aperte qualquer tecla para encerrar...");
            Console.ReadKey();




        }
    }
}
