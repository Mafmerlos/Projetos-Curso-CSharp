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

namespace Banco_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senha = 0;
            string menu = "s";
            List<int> fila = new List<int>();
            while (menu == "s")
            {
                Console.WriteLine("Digite opção: "
                    + "\n1 - Pegar senha "
                    + "\n2 - Chamar senha "
                    + "\n3 - Imprimir a fila"
                    + "\n4 - Encerrar o programa"
                    );

                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        fila.Add(++senha);
                        Console.WriteLine($"Senha: {senha}");
                        Console.WriteLine($"Tamanho da lista: {fila.Count}");
                        break;

                    case 2:
                        Console.WriteLine($"Senha chamada: {senha} ");
                        fila.Remove(senha);
                    
                        break;

                    case 3:
                        if (fila.Count > 0)
                        {

                            for (int i = 0; i < fila.Count; i++)
                            {
                                Console.WriteLine($"Senha {i}: {fila[i]}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Vazia.");
                        }
                        break;
                    case 4:

                        break;
                    default:
                        Console.WriteLine("Encerrado");
                        break;
                }

                
                Console.WriteLine("Deseja continuar: sim (s) ou nao (n) ");
                menu = Console.ReadLine();
                Console.Clear();

            }
            //fila.Add(1);

            //fila.Remove(1);
            //fila.RemoveAt(0);


        }
    }
}