using System;


/*
 * Faça um programa que solicite um número inteiro para o usuário
 * Calcule e mostre o Sucessor e o Antecessor.
 */

namespace AntecessorSucessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Seu antecessor é: {numero - 1}"); 
            Console.WriteLine($"Seu sucessor é: {numero + 1}");


        }
    }
}
