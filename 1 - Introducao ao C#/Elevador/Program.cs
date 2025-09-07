using System;
using System.Runtime.Serialization;


/*
 Faça um programa que mostre se um elevador pode entrar em funcionamento ou não.
 Primeiro, o programa deve solicitar o peso máximo, em Kg, suportado pelo elevador e
 3 pessoas irão utilizá-lo. Depois, solicitar o peso de cada pessoa e, no
 final, exibir se o elevador poderá entrar em funcionamento ou não. Caso a soma dos pesos
 das pessoas for maior que o peso máximo suportado pelo elevador, ele não poderá entrar
 em funcionamento.
 */


namespace Elevador
{
    internal class Program
    {

        static void Main(string[] args)
        {
            const double PESOMAXIMOSUPORTADO = 500.0;
            Console.WriteLine("Digite o peso da pessoa 01 em (Kg): ");
            double peso01 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso da pessoa 02 em (Kg): ");
            double peso02 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso da pessoa 03: (Kg): ");
            double peso03 = double.Parse(Console.ReadLine());

            double somaDosPesos = peso01 + peso02 + peso03;
            bool excedido = somaDosPesos >= PESOMAXIMOSUPORTADO;
            /*
            if (!excedido)
            {
                Console.WriteLine("Elevador funcionando");
            } else
            {
                Console.WriteLine($"O peso foi excedido. O elevador não pode funcionar...");
            }
           */
            Console.WriteLine(!excedido ? "Elevador funcionando" : "O peso foi excedido. O elevador não pode funcionar...");
            
            Console.WriteLine("Digite ENTER para encerrar o programa...");
            Console.ReadLine();


        }
    }
}
