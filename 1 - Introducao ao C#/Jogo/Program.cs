using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Jogo
 * 
 * Soco  - s => 2 pontos
 * Chute - c => 5 pontos 
 * Magia - m => 10 pontos
 * 
 * Deseja executar um golpe (s-soco c-chute m-magia x-sair)?
 * 
 * x => sair
 * 
 * Soco(s)  => 10 => 20 pontos
 * Chute(s) => 3 => 15 pontos
 * Magia(s) => 4 => 40 pontos
 * Total de pontos => 75 pontos
 * 
 * -- Pressione ENTER para encerrar --
 */

namespace Jogo
{
    internal class Program
    {
        const int VALORPONTOSSOCO = 2, VALORPONTOSCHUTE = 5, VALORPONTOSMAGIA = 10;
        static void Main(string[] args)
        {
            string entradaUsuario = "",saidaUsuario = "s", golpe = "";
            int socos = 0, chutes = 0, magias = 0, totalPontosFinal = 0, quantidadePontosSoco = 0,
                quantidadePontosChute = 0, quantidadePontosMagia = 0;

            Console.WriteLine("Deseja jogar? (s - sim / n - não)");
            entradaUsuario = Console.ReadLine().ToLower();
            if (entradaUsuario != "s")
                return;

            Console.WriteLine("--- JOGO DE LUTA ---");
            while (saidaUsuario != "x")
            {
                Console.WriteLine(" Deseja executar um golpe (s-soco c-chute m-magia x-sair)?");
                golpe = Console.ReadLine().ToLower();

                switch (golpe)
                {
                    case "s":
                        socos++;
                        break;
                    case "c":
                        chutes++;
                        break;
                    case "m":
                        magias++;
                        break;
                    case "x":
                        saidaUsuario = golpe;
                        break;
                }
                    
            }

            quantidadePontosSoco = socos * VALORPONTOSSOCO;
            quantidadePontosChute = chutes * VALORPONTOSCHUTE;
            quantidadePontosMagia = magias * VALORPONTOSMAGIA;
            totalPontosFinal = quantidadePontosSoco + quantidadePontosChute + quantidadePontosMagia;

            Console.WriteLine($"Soco (s) => Quantidade de socos : {socos}  => {quantidadePontosSoco} Pontos");
            Console.WriteLine($"Chute (s) => Quantidade de chutes : {chutes} => {quantidadePontosChute} Pontos");
            Console.WriteLine($"Magia (s) => Quantidade de magias : {magias} => {quantidadePontosMagia} Pontos");
            Console.WriteLine($"Total de Pontos: {totalPontosFinal}");
            Console.WriteLine("Digite ENTER para sair...");
            Console.ReadLine();
        }
    }
}
