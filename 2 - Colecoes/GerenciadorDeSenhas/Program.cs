using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeSenhas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcaoEntradaSistema = "s";

            while (opcaoEntradaSistema == "s")
            {
                Console.WriteLine("1.Gerar senha para atendimento comum\n" +
                    "2. Gerar senha para atendimento prioritário\n" +
                    "3. Chamada da senha para atendimento\n" +
                    "4. Visualizar fila de chamada\n" +
                    "5. Encerramento do atendimento\n"
               );







                Console.WriteLine("Deseja continuar usando o sistema? Sim (s) e Não (n)");
                opcaoEntradaSistema = Console.ReadLine();

                while (opcaoEntradaSistema != "s" && opcaoEntradaSistema != "n")
                {
                    Console.WriteLine("Digite uma opçao válida\n");
                    Console.WriteLine("Deseja continuar usando o sistema? Sim (s) e Não (n)");
                    opcaoEntradaSistema = Console.ReadLine();
                   
                    continue;
                }
            }


        }
    }
}
