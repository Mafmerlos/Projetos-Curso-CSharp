using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Crie um programa em C# que:
Crie uma lista de números inteiros.
Permita ao usuário digitar 5 números inteiros e adicione-os à lista.
Exiba todos os números armazenados.
Mostre o maior e o menor número da lista. */



namespace MaiorMenorList
{
    internal class Program
    {
       static void Main(string[] args)
        {
            int numero = 0, maior = int.MinValue, menor = int.MaxValue; // Menor e maior valores possiveis para tratamento
            List<int> list = new List<int>(5);

            for (int i = 0; i < 5; i++)
            { 
                Console.WriteLine("Digite um numero:");
                numero = int.Parse(Console.ReadLine());
                list.Add(numero);

                if(list[i] < menor)
                {
                    menor = list[i];
                }

                if (list[i] > maior)
                {
                    maior = list[i];
                }   
                

            }


            Console.WriteLine($"\nMaior: {maior}");
            Console.WriteLine($"Menor: {menor}");
            foreach (int i in list) Console.Write(i + " ");

        }
    }
}
