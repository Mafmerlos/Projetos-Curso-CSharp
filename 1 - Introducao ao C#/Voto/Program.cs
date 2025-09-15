using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

/* Em uma eleição presidencial, existem quatro candidatos.Os votos são informados através de códigos.
 * Os códigos utilizados são:
    • 1,2,3,4 votos para os respectivos candidatos;
    • 5 voto nulo; 
    • 6 voto em branco.
    Assim, escreva um programa para receber um único voto e imprima: 
    • Se o usuário votou em um candidato: "Voto contabilizado com sucesso..."
    • Se o usuário votou nulo: "Voto nulo contabilizado..."
    • Se o usuário votou em branco: "Voto branco contabilizado..
Se o voto for diferente de todas as opções acima: "Voto inválido..."
*/


namespace Voto
{
    internal class Program
    {
        const int CANDIDATO1 = 1, CANDIDATO2 = 2, CANDIDATO3 = 3, CANDIDATO4 = 4;
        static void Main(string[] args)
        {
            int voto = 0, contadorVotosCandidatos = 0, contadorVotosNulos = 0, contadorVotosBrancos = 0, contadorVotosInvalidos = 0, totalDeVotos = 0;
            string continuar = "s";

            while (continuar == "s")
            {
                Console.WriteLine("Digite o numero que deseja votar (1-6):");
                voto = int.Parse(Console.ReadLine());

                switch (voto)
                {
                    case CANDIDATO1:
                    case CANDIDATO2:
                    case CANDIDATO3:
                    case CANDIDATO4:
                        Console.WriteLine("Voto contabilizado com sucesso...");
                        contadorVotosCandidatos++;
                        break;
                    case 5:
                        Console.WriteLine("Voto nulo contabilizado...");
                        contadorVotosNulos++;
                        break;
                    case 6:
                        Console.WriteLine("Voto branco contabilizado...");
                        contadorVotosBrancos++;
                        break;
                    default:
                        Console.WriteLine("Voto inválido...");
                        contadorVotosInvalidos++;
                        break;
                }
                Console.WriteLine("Deseja continuar votando? s - (sim) / n - (não)");
                continuar = Console.ReadLine();
                Console.Clear();
            }
            totalDeVotos =  contadorVotosCandidatos + contadorVotosNulos + contadorVotosBrancos + contadorVotosInvalidos;
            Console.WriteLine("Votos");
            Console.WriteLine($"Quantidade de votos válidos: {contadorVotosCandidatos} ");
            Console.WriteLine($"Quantidade de votos nulos: {contadorVotosNulos} ");
            Console.WriteLine($"Quantidade de votos brancos: {contadorVotosBrancos} ");
            Console.WriteLine($"Quantidade de votos inválidos: {contadorVotosInvalidos} ");
            Console.WriteLine($"Total de votos: {totalDeVotos} ");

            Console.WriteLine("Digite ENTER para encerrar o programa...");
            Console.ReadLine();
        }
    }
}
