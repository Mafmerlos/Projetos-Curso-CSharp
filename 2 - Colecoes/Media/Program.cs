using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int qtdeNotas = 3;
            double soma = 0;

            for (int i = 0; i < qtdeNotas; i++)
            {
                Console.Write("Digite a nota:");
                double nota = double.Parse(Console.ReadLine());
                soma += nota;
            }

            Console.WriteLine($"Média1:{soma / qtdeNotas}");

            //---------------------------------------------------------

            double[] notas = new double[3];

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("Digite a nota:");
                notas[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Média2:{notas.Average()}");
        }
    }
}
