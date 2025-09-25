using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Controlar uma fila de um banco
* 4 opções
* 1 - Pegar senha (sequencial - valor inicial da senha é 1)
* 2 - Chamar senha (chamar na sequencia)
* 3 - Imprimir a fila
* 4 - Encerrar o programa (se a fila estiver vazia)
*/

namespace Banco_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcaoSistema = "s";
            int opcaoMenu = 0;
            Queue<int> fila  = new Queue<int>();

            while (opcaoSistema == "s")
            {
                Console.WriteLine("1 - Pegar senha\n" +
                    "2 - Chamar senha\n" +
                    "3 - Imprimir a fila\n" +
                    "4 - Encerrar o programa\n");

                opcaoMenu = int.Parse(Console.ReadLine());

                switch (opcaoMenu)
                {
                    case 1:
                        fila.Append(0);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;  
                    default:break;
                }


                Console.WriteLine("Deseja continuar usando o sistema: Sim (s) | Não (n)");
                opcaoSistema = Console.ReadLine();

            }

        }
    }
}
