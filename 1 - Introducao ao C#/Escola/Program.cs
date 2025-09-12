using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  O usuário vai entrar com o nome do aluno e 5 notas para este aluno (estrutura de repetição).
  Calcular a média e apresentar nome do aluno e sua média
  "Aluno 1 média 7."
  Reprovado: < 5
  Exame: >= 5 e < 7
  Aprovado: >= 7

  Colocar o programa em loop para o usuário entrar com quantos alunos ele desejar.
  No final, o programa deve exibir a quantidade total de alunos e quantos foram reprovados, ficaram em exame e aprovados.

  Total Alunos: 10
  Reprovados: 2
  Exame: 5
  Aprovados: 3
 
 */
namespace Escola
{   
    internal class Program
    {
        const int NUMERONOTAS=5;
        static void Main(string[] args)
        {
            string entrada = "";
           double media = 0.0;
            int totalAlunos = 0, reprovados = 0, recuperacao = 0, aprovados = 0;
            do
            {
                Console.WriteLine("Entre com o nome do aluno: ");
                string nomeAluno = Console.ReadLine();

                double soma = 0.0;

                for(int i=0; i < NUMERONOTAS ; i++)
                {
                    Console.WriteLine($"Digite a nota {i + 1}: ");
                    soma += double.Parse(Console.ReadLine());
                }
                media = soma / NUMERONOTAS;
                Console.WriteLine($"Aluno: {totalAlunos + 1} ({nomeAluno}) Media: {media}");
               

                if (media < 5)
                {
                    Console.WriteLine($"O aluno {totalAlunos + 1} foi reprovado.");
                    reprovados++;

                } else if (media >= 5 && media < 7)
                {
                    Console.WriteLine($"O aluno {totalAlunos + 1} ficou de recuperação.");
                    recuperacao++;

                } else
                {
                    Console.WriteLine($"O aluno {totalAlunos + 1} foi aprovado.");
                    aprovados++;
                }

                Console.WriteLine("Deseja inserir aluno (s/n)\n");
                entrada = Console.ReadLine().ToLower();
                totalAlunos++;


            } while (entrada == "s");
    
            Console.WriteLine($"Total de alunos: {totalAlunos}");
            Console.WriteLine($"Reprovados: {reprovados}");
            Console.WriteLine($"Exame: {recuperacao}");
            Console.WriteLine($"Aprovados: {aprovados}");







        }
    }
}
