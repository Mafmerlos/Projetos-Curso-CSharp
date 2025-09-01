using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double real, cotacaoDolar = 5.45, valorTotal;

        Console.WriteLine("Digite o valor que deseja converter em reais");
        real = double.Parse(Console.ReadLine());
        valorTotal = (real / cotacaoDolar);
            
            Console.Write($"Valor do real: {real}\n");
            Console.Write($"Valor do dolar: {cotacaoDolar}\n");
            Console.Write($"Valor total em dolar: {valorTotal}\n");

            Console.WriteLine("Pressione enter para encerrar...");
            Console.ReadLine();


        }
    }
}
