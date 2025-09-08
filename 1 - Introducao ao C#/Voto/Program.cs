using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Em uma eleição presidencial, existem quatro candidatos.Os votos são informados através de códigos.
 * Os códigos utilizados são:
    • 1,2,3,4 votos para os respectivos candidatos;
    • 5 voto nulo; 
    • 6 voto em branco.
    Assim, escreva um programa para receber um único voto e imprima: 
    • Se o usuário votou em um candidato: "Voto contabilizado com sucesso..."
    • Se o usuário votou nulo: "Voto nulo contabilizado..."
    • Se o usuário votou em branco: "Voto branco contabilizado..
Se o voto for diferente de todas as opções acima: "Voto inválido..."
*/


namespace Voto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int voto = 0;

            Console.WriteLine("Digite o numero que deseja votar (1-6):");
            voto = int.Parse(Console.ReadLine());

            switch (voto) {
                case 1: 
                case 2: 
                case 3: 
                case 4: 
                    Console.WriteLine("Voto contabilizado com sucesso...");
                    break;
                case 5: Console.WriteLine("Voto nulo contabilizado...");
                    break;
                case 6: Console.WriteLine("Voto branco contabilizado...");
                    break;
                default: Console.WriteLine("Voto inválido...");
                    break;
            }

            Console.WriteLine("Digite ENTER para encerrar o programa...");
            Console.ReadLine();
        }
    }
}
