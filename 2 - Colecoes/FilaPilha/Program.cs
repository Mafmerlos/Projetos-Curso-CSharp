using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

/*Crie uma fila de inteiros e uma pilha de inteiros.
Permita que o usuário digite 5 números inteiros.
Cada número digitado deve ser inserido na fila e também na pilha.
Exiba o conteúdo da fila (na ordem de inserção).
Exiba o conteúdo da pilha (na ordem inversa de inserção).
Retire um elemento da fila (Dequeue) e um elemento da pilha (Pop), mostrando quais foram removidos.
Mostre novamente o conteúdo atualizado da fila e da pilha.*/

namespace FilaPilha
{
    internal class Program
    {

        static void Main(string[] args)
        {
            const int QTDNUMERO = 5;
            int numero = 0;
            Queue<int> fila = new Queue<int>(QTDNUMERO);
            Stack<int> pilha = new Stack<int>(QTDNUMERO);

            for (int i = 0; i < QTDNUMERO; i++)
            {
                Console.Write("Digite numero: ");
                numero = int.Parse((Console.ReadLine()));
                fila.Enqueue(numero);
                pilha.Push(numero);
            }

            Console.WriteLine("--Fila--");
            foreach (int i in fila)
            {
                Console.Write($"{i}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("--Pilha--");
            foreach (int i in pilha)
            {
                Console.Write($"{i}");
            }
            Console.WriteLine("\n");

            int primeiroFila = fila.Dequeue();
            int primeiroPilha = pilha.Pop();

           Console.WriteLine($"--Primeiro elemento da fila: {primeiroFila} --");
           Console.WriteLine($"--Último elemento da fila: {primeiroPilha} --");
           Console.WriteLine("\n");

            Console.WriteLine("--Fila--");
            foreach (int i in fila)
            {
                Console.Write($"{i}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("--Pilha--");
            foreach (int i in pilha)
            {
                Console.Write($"{i}");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Digite ENTER para encerrar...");
            Console.ReadLine();

        }
    }
}
