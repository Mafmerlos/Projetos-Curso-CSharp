using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string SOCO = "s", CHUTE = "c", MAGIA = "m", SAIR = "x";
            const int VALORSOCO = 2, VALORCHUTE = 5, VALORMAGIA = 10;
            string respostaUsuario = "s";
            int somaSocos = 0, somaChutes = 0, somaMagia = 0;
            int contadorSocos = 0, contadorChutes = 0, contadorMagia = 0;

            while (respostaUsuario == "s")
            {
                Console.WriteLine();
                Console.WriteLine("     \tLUTINHA DOS CAMPEÕES     ");
                Console.WriteLine();
                Console.WriteLine("\t Soco  - s => 2 pontos     ");
                Console.WriteLine("\t Chute - c => 5 pontos     ");
                Console.WriteLine("\t Magia - m => 10 pontos    ");

                Console.WriteLine();
                Console.Write("Deseja executar um golpe (s-soco c-chute m-magia x-sair)?    ");
                string golpe = Console.ReadLine();

                switch (golpe)
                {
                    case SOCO:
                        Console.Clear();
                        Console.WriteLine("\nVocê deu um SOCO\n");
                        somaSocos += VALORSOCO;
                        contadorSocos++;
                        break;
                    case CHUTE:
                        Console.Clear();
                        Console.WriteLine("\nVocê deu um CHUTE\n");
                        somaChutes += VALORCHUTE;
                        contadorChutes++;
                        break;
                    case MAGIA:
                        Console.Clear();
                        Console.WriteLine("\nVocê usou uma MAGIA\n");
                        somaMagia += VALORMAGIA;
                        contadorMagia++;
                        break;
                    case SAIR:
                        Console.Clear();
                        respostaUsuario = "n";
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida,tente novamente com as opções válidas");
                        respostaUsuario = "s";
                        break;

                }

            }
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"\tSoco(s)  => {contadorSocos} => {somaSocos} pontos");
            Console.WriteLine($"\tChute(s)  => {contadorChutes} => {somaChutes} pontos");
            Console.WriteLine($"\tMagia(s) => {contadorMagia} => {somaMagia} pontos");
            Console.WriteLine($"\tTotal de pontos => {somaSocos + somaChutes + somaMagia} pontos");
            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para finalizar o programa    ");
            Console.ReadLine();

        }
    }
}
