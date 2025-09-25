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

/*
 * Tarefas 
 * 1 - Continuar o teste de mesa do array - ParImpar
 * 2 - Fazer o teste de mesa da Lista - ParImpar
 * 3 - Fazer o teste de mesa do banco
 * 4 - Estudar Queue<T> e Stack<T>
 * 5 - Alterar Banco_List para Banco_Queue utilizando o Queue<T> - Criar um novo projeto Banco_Queue 
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
                        break;

                    case 2:
                        if(fila.Count > 0) { 
                        Console.WriteLine($"Senha chamada: {fila[0]} ");
                        fila.RemoveAt(0);
                        }
                        else
                        {
                            Console.WriteLine("A fila está vazia. Encerre ou pegue uma senha!\n");
                        }
                            break;

                    case 3:
                        if (fila.Count > 0)
                        {

                            for (int i = 0; i < fila.Count; i++)
                            {
                                Console.WriteLine($"Senha {i+1}: {fila[i]}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Vazia.");
                        }
                        break;
                    case 4:
                        if(fila.Count > 0)
                        {
                            Console.Write("Não foi possivel encerrar o programa." +
                                " Chame todos antes de encerrar!\n");  
                            continue;
                            

                        } else
                        {
                            Console.WriteLine("Encerrando programa...");
                            return;
                        }

           
                    default:
                        Console.WriteLine("Digite uma opção válida");
                        break;
                }

                
                Console.WriteLine("Deseja continuar: sim (s) ou nao (n) ");
                menu = Console.ReadLine();
                Console.Clear();

            }
        }
    }
}