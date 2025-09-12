using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Fazer teste de mesa e realizar a tela do usuário

namespace ElevadorLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Programa do Elevador--\n");

            Console.Write("Peso máximo suportado pelo elevador em Kg:"); //entrada do peso suportado em Kg
            double pesoMaximoSuportadoPeloElevador = double.Parse(Console.ReadLine()); // 500

            int numeroDePessoas = 0;
            bool deuCerto;
            do
            {
                Console.Write("Número de pessoas que desejam utilizá-lo:"); //Numero de pessoas que vao usar
                deuCerto = int.TryParse(Console.ReadLine(), out numeroDePessoas); //Só sai do loop se for valor válido
            } while (!deuCerto || numeroDePessoas < 0); //enquanto nao for inteiro ou negativo fica esperando entrada correta

            double somaDosPesosDasPessoas = 0;

            for (int i = 0; i < numeroDePessoas; i++)
            {
                Console.Write($"Peso da {i + 1}ª pessoa em Kg:"); //não altera o valor de i.
                double pesoDaPessoa = double.Parse(Console.ReadLine());
                somaDosPesosDasPessoas += pesoDaPessoa;
            }
            if (somaDosPesosDasPessoas > pesoMaximoSuportadoPeloElevador)
                Console.WriteLine("Elevador não pode entrar em funcionamento.");
            else
                Console.WriteLine("Elevador funcionando...");

            Console.WriteLine("\n--Pressione ENTER para encerrar--");
            Console.ReadLine();

        }
    }
}
