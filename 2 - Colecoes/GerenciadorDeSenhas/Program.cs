using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace GerenciadorDeSenhas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcaoMenu = 0;
            Queue<int> filaAtendimento = new Queue<int>();
            Queue<int> filaAtendimentoPrioritario = new Queue<int>();
            int senha = 0, quantidadeSenhasComuns = 0, quantidadeSenhasPrioritarias = 0;

            while (opcaoMenu != 5)
            {
                Console.WriteLine("1.Gerar senha para atendimento comum\n" +
                    "2. Gerar senha para atendimento prioritário\n" +
                    "3. Chamada da senha para atendimento\n" +
                    "4. Visualizar fila de chamada\n" +
                    "5. Encerramento do atendimento");

                opcaoMenu = int.Parse(Console.ReadLine());
                while (opcaoMenu < 0 || opcaoMenu > 5)
                {
                    Console.WriteLine("Digite uma opção válida\n");
                    Console.WriteLine("1.Gerar senha para atendimento comum\n" +
                    "2. Gerar senha para atendimento prioritário\n" +
                    "3. Chamada da senha para atendimento\n" +
                    "4. Visualizar fila de chamada\n" +
                    "5. Encerramento do atendimento");
                    opcaoMenu = int.Parse(Console.ReadLine());
                    continue;
                }


                switch (opcaoMenu)
                {
                    case 1:
                        filaAtendimento.Enqueue(++senha);
                        quantidadeSenhasComuns++;
                        Console.Clear();
                        break;

                    case 2:
                        filaAtendimentoPrioritario.Enqueue(++senha);
                        quantidadeSenhasPrioritarias++;
                        Console.Clear();
                        break;

                    case 3:
                        if (filaAtendimentoPrioritario.Count > 0)
                        {
                            Console.WriteLine($"Senha (Preferencial) chamada: {filaAtendimentoPrioritario.ElementAt(0)}\n");
                            filaAtendimentoPrioritario.Dequeue();
                            Console.WriteLine("Digite ENTER para continuar");
                            Console.ReadLine();
                            Console.Clear();

                        }
                        else if (filaAtendimento.Count > 0)
                        {
                            Console.WriteLine($"Senha (Comum) chamada: {filaAtendimento.ElementAt(0)}\n");
                            filaAtendimento.Dequeue();
                            Console.WriteLine("Digite ENTER para continuar");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("As filas estão vazias, pode encerrar o atendimento...\n");
                            Console.WriteLine("Digite ENTER para continuar");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 4:
                        if (filaAtendimentoPrioritario.Count == 0 && filaAtendimento.Count == 0)
                        {
                            Console.WriteLine("As filas estão vazias...");
                            Console.WriteLine("\n");
                            Console.WriteLine("Digite ENTER para continuar");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.Write("Fila de atendimento: ");
                            foreach (var senhaAtendimentoPrioritario in filaAtendimentoPrioritario)
                            {
                                Console.Write($"{senhaAtendimentoPrioritario}" + " ");
                            }
                            foreach (var senhaAtendimento in filaAtendimento)
                            {
                                Console.Write($"{senhaAtendimento}" + " ");
                            }
                            Console.WriteLine("\n");
                            Console.WriteLine("Digite ENTER para continuar");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 5:
                        if (filaAtendimentoPrioritario.Count > 0 || filaAtendimento.Count > 0)
                        {
                            Console.WriteLine("Atendimento não pode ser encerrado, ainda existem pessoas aguardando atendimento...\n");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine($"Quantidade de atendimentos comuns: {quantidadeSenhasComuns}");
                            Console.WriteLine($"Quantidade de atendimentos prioritários: {quantidadeSenhasPrioritarias}");
                            Console.WriteLine("Atendimento está sendo encerrado, até a próxima...");
                            return;
                        }

                }

            }

        }
    }
}
