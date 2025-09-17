using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace ResoluçãoExercício03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("------Bem-vindo ao jogo do Par ou Ímpar------");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("");

            string entradaUsuario = "s";
            int vitoriasJogador = 0, vitoriasComputador = 0, vezesJogadas = 0;

            while (entradaUsuario == "s")
            {
                Console.Write("Você quer par (p) ou ímpar (i)? ");
                string opcaoJogador = Console.ReadLine().ToLower();
                while (opcaoJogador != "p" && opcaoJogador != "i")
                {
                    Console.WriteLine("Digite uma opção válida para jogar...");
                    Console.Write("Você quer par (p) ou ímpar (i)? ");
                    opcaoJogador = Console.ReadLine().ToLower();
                    continue;
                }

                Console.Write("Informe um número inteiro: ");
                int numeroJogador = int.Parse(Console.ReadLine());

                Random roleta = new Random();
                int numeroComputador = roleta.Next(100);

                int valorFinal = numeroJogador + numeroComputador;

                Console.Clear();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("--  Dados da rodada do jogo (Par ou Ímpar) --");
                Console.WriteLine($"* Seu numero (Jogador): {numeroJogador}");
                Console.WriteLine($"* Numero computador: {numeroComputador}");
                Console.WriteLine($"* Resultado Final: {valorFinal}");


                switch (opcaoJogador)
                {
                    case "p":
                        Console.WriteLine("Você (Jogador) escolheu ser PAR nessa rodada");
                        if (valorFinal % 2 == 0)
                        {
                            Console.WriteLine("O resultado dessa rodada foi par, você ganhou!");
                            Console.WriteLine("---------------------------------------------");
                            vitoriasJogador++;

                        }
                        else
                        {
                            Console.WriteLine("O resultado dessa rodada foi impar, você perdeu!");
                            Console.WriteLine("---------------------------------------------");
                            vitoriasComputador++;
                        }
                        break;
                    case "i":
                        Console.WriteLine("Você (Jogador) escolheu ser IMPAR nessa rodada");
                        if (valorFinal % 2 == 1)
                        {
                            Console.WriteLine("O resultado da rodada foi impar, você ganhou!");
                            Console.WriteLine("---------------------------------------------");
                            vitoriasJogador++;
                        }
                        else
                        {
                            Console.WriteLine("O resultado da rodada foi par, você perdeu!");
                            Console.WriteLine("---------------------------------------------");
                            vitoriasComputador++;
                        }
                        break;
                    default:
                        break;
                }
                vezesJogadas++;

                Console.WriteLine("\nDeseja jogar mais uma rodada? Sim (s) / Nao (n) ");
                entradaUsuario = Console.ReadLine().ToLower();

                while (entradaUsuario != "s" && entradaUsuario != "n")
                {
                    Console.WriteLine("Digite uma opção válida...");
                    Console.WriteLine("Você deseja jogar mais uma rodada? Sim (s) / Não (n) ");
                    entradaUsuario = Console.ReadLine().ToLower();
                }

                if (entradaUsuario == "s")
                {
                    Console.WriteLine("Você deciciu continuar jogando. Boa sorte nessa rodada!");
                }

            }

            Console.Clear();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"---- Placar final do jogo (Par ou Ímpar) ---- ");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"* Foi jogado {vezesJogadas} vez(es)");
            Console.WriteLine($"* Você (jogador) ganhou {vitoriasJogador} vez(es)");
            Console.WriteLine($"* O computador ganhou {vitoriasComputador} vez(es)");

            if (vitoriasJogador > vitoriasComputador)
            {
                Console.WriteLine("* Você (jogador) venceu o jogo!");
                Console.WriteLine("---------------------------------------------");
            }
            else if (vitoriasComputador > vitoriasJogador)
            {
                Console.WriteLine("* O computador venceu o jogo! Não desista...");
                Console.WriteLine("---------------------------------------------");
            }
            else
            {
                Console.WriteLine("O jogo terminou empatado");
                Console.WriteLine("---------------------------------------------");
            }

            Console.WriteLine("\nAutor: Matheus Figueira Merlos");
            Console.WriteLine("Digite ENTER para encerrar...");
            Console.ReadLine();
        }
    }
}
