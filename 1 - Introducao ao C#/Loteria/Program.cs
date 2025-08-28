using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 3 amigos => fazem apostas
 * ganharam o prêmio
 * Quanto cada um recebe? * 
 *  R.: Depende de quanto cada um apostou.
 *  R.: Quanto é o prêmio!!!
 *  
 * Como faremos o programa para calcular
 * Entrada => Valor do prêmio e valor das apostas de cada amigo.
 * Processamento => Calculo de quanto cada um recebe. (%)
 * Saída => Impressão do valor que cada amigo recebe.
*/




namespace Loteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double premio, aposta1, aposta2, aposta3;

            Console.WriteLine("Digite o valor do premio: ");
            premio = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da aposta 1: ");
            aposta1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da aposta 2: ");
            aposta2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da aposta 3: ");
            aposta3 = double.Parse(Console.ReadLine());


            double somaValorApostado = aposta1 + aposta2 + aposta3; 

            Console.WriteLine("Valores recebidos: ");
            Console.WriteLine($"Amigo 1: {aposta1 / somaValorApostado * premio}");
            Console.WriteLine($"Amigo 2: {aposta2 / somaValorApostado * premio}");
            Console.WriteLine($"Amigo 3: {aposta3 / somaValorApostado * premio}");




            Console.WriteLine("Pressione Enter para encerrar");
            Console.ReadLine();

        }
    }
}
