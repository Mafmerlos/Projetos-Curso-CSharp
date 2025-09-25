using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 ---Loteria--
int qtdeNumeros = 10;
 int i = 0;

 Queue<int> fila = new Queue<int>(qtdeNumeros);
 
 Random roleta = new Random();

 do
 {
     fila.Enqueue(roleta.Next(25));
     i++;
 } while (i < qtdeNumeros);
Console.Write("\nOs números sorteados foram:");
foreach (var item in fila)
{
    Console.Write(item);
    Console.Write("  ");
}
 */

namespace Loteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtdeNumeros = 10;
            int i = 0;

            Queue<int> fila = new Queue<int>(qtdeNumeros);

            Random roleta = new Random();

            do
            {
                fila.Enqueue(roleta.Next(25));
                i++;
            } while (i < qtdeNumeros);
            Console.Write("\nOs números sorteados foram:");
            foreach (var item in fila)
            {
                Console.Write(item);
                Console.Write("  ");
            }
        }
    }
}
