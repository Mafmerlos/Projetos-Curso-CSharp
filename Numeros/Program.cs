using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//int n1 = Convert.ToInt32(Console.ReadLine());

namespace Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            int n1 = int.Parse(Console.ReadLine());

            //Formas de escritas no writeLine
            Console.WriteLine("Dobro: " + n1 * 2);
            Console.WriteLine("Dobro: {0}", n1 * 2);
            Console.WriteLine("{0} {1}", "Dobro:" , n1 * 2);
            Console.WriteLine($"Dobro: { n1 * 2} \nTriplo: {n1 * 3}"); //Mais simples para fazer, pois voce mesmo vai montando a própria String
           

            Console.WriteLine("Pressione entre para encerrar");
            Console.ReadLine();

                }
    }
}
