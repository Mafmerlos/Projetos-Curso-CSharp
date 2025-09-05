using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Um pescador comprou um microcomputador para controlar o rendimento diário de seu trabalho. 
Toda vez que ele traz um peso de peixes maior que o estabelecido pelo regulamento de pesca do estado de 
São Paulo (50 quilos) deve pagar uma multa de R$ 4,00 por quilo excedente. Assim, faça um
programa que leia o peso de peixes e verifique se há excesso. 
Se houver, o programa também deve calcular o valor da multa que o pescador deverá pagar. 
No final, o programa deve imprimir o excesso e a multa paga pelo pescador */

namespace Pescador
{
    internal class Program
    {
        const double PESOMAXIMOPEIXE = 50.0;
        const double VALORMULTA = 4.0;
        static void Main(string[] args)
        {
            double pesoPeixePescado;

            Console.WriteLine("Digite o peso do peixe pescado: ");
            pesoPeixePescado = double.Parse(Console.ReadLine());

            
            if (pesoPeixePescado > PESOMAXIMOPEIXE)
            {
                double pesoExcedido = pesoPeixePescado - PESOMAXIMOPEIXE;
                double multa = pesoExcedido * VALORMULTA;
                Console.WriteLine($"Peso do peixe pescado: {pesoPeixePescado} \n" +
                    $"Peso excedido: {pesoExcedido} \n" +
                    $"Valor da multa: {multa}");
            }
            else
            {
                Console.WriteLine($"Peixe abaixo da cota permitida. Peso do peixe: {pesoPeixePescado}");
            }

            Console.WriteLine("Digite ENTER para encerrar...");
            Console.ReadLine();
        }
    }
}
