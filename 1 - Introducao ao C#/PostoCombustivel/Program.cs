using System;

/*
Analise a seguinte informação:

Em um jogo, existe um posto que está vendendo combustíveis com a seguinte tabela de descontos:

Álcool
até 20 litros (inclusive 20 litros), desconto de 2% por litro
acima de 20 litros, desconto de 5% por litro

Gasolina
até 20 litros (inclusive 20 litros), desconto de 3% por litro
acima de 20 litros, desconto de 6% por litro

Após à análise, faça um programa que leia o número de litros vendidos 
e o tipo de combustível (codificado da seguinte forma: 1-álcool, 2-gasolina).
calcule e imprima o valor a ser pago pelo jogador, sabendo-se que 
o preço do litro da gasolina é R$ 6.10 e o preço do litro do álcool é R$ 4.20
 */

namespace PostoCombustivel
{
    internal class Program
    {
        const double PRECOALCOOL = 4.20, PRECOGASOLINA = 6.10, NUMEROBASELITROS = 20.0;
        //TODO : Refatorar o if e else e a escrita desse código e realizar return early
        static void Main(string[] args)
        {
            int tipoCombustivel = 0;
            double litrosVendidos = 0.0, valorPagar = 0.0, custoAlcool = 0.0, custoGasolina = 0.0;

            Console.WriteLine("Digite o tipo de combustível: \n1 - Alcool \n2 - Gasolina "); //TODO : negativo
            tipoCombustivel = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantos litros vendidos: ");
            litrosVendidos = double.Parse(Console.ReadLine());

            #region switch

            switch (tipoCombustivel)
            {
                case 1:
                    if (litrosVendidos > NUMEROBASELITROS)
                    {
                        double descontoAlcoolMaiorQueNumeroBase = PRECOALCOOL * 0.05; //DESCONTO POR LITRO
                        custoAlcool = PRECOALCOOL - descontoAlcoolMaiorQueNumeroBase;
                        valorPagar = litrosVendidos * custoAlcool;
                        Console.WriteLine($"Valor a ser pago: {valorPagar:0.00}");
                    }
                    else
                    {
                        double descontoAlcoolMenorQueNumeroBase = PRECOALCOOL * 0.02; //DESCONTO POR LITRO
                        custoAlcool = PRECOALCOOL - descontoAlcoolMenorQueNumeroBase;
                        valorPagar = litrosVendidos * custoAlcool;
                        Console.WriteLine($"Valor a ser pago: {valorPagar:0.00}");
                    } break;
                case 2:
                    if (litrosVendidos > NUMEROBASELITROS)
                    {
                        double descontoGasolinaMaiorQueNumeroBasePorLitro = PRECOGASOLINA * 0.06; //DESCONTO POR LITRO
                        custoGasolina = PRECOGASOLINA - descontoGasolinaMaiorQueNumeroBasePorLitro;
                        valorPagar = litrosVendidos * custoGasolina;
                        Console.WriteLine($"Valor a ser pago: {valorPagar:0.00}");
                    }
                    else
                    {
                        double descontoGasolinaMenorQueNumeroBase = PRECOGASOLINA * 0.03; //DESCONTO POR LITRO
                        custoGasolina = PRECOGASOLINA - descontoGasolinaMenorQueNumeroBase;
                        valorPagar = litrosVendidos * custoGasolina;
                        Console.WriteLine($"Valor a ser pago: {valorPagar:0.00}");
                    } break;
                default: Console.WriteLine("Digite um tipo de combustivel válido");
                    break;
            }
            Console.WriteLine("Digite ENTER para encerrar o programa...");
            Console.ReadLine();

        }

        #endregion

        /*
        if(tipoCombustivel == 1)
        {
            if (litrosVendidos > NUMEROBASELITROS)
            {
            double descontoAlcoolMaiorQueNumeroBase = PRECOALCOOL * 0.05; //DESCONTO POR LITRO
               custoAlcool = PRECOALCOOL - descontoAlcoolMaiorQueNumeroBase;
                valorPagar = litrosVendidos * custoAlcool;
                Console.WriteLine($"Valor a ser pago: {valorPagar:F2}");
            } else
            {
            double descontoAlcoolMenorQueNumeroBase = PRECOALCOOL * 0.02; //DESCONTO POR LITRO
                custoAlcool = PRECOALCOOL - descontoAlcoolMenorQueNumeroBase;
                valorPagar = litrosVendidos * custoAlcool;
                Console.WriteLine($"Valor a ser pago: {valorPagar:F2}");
            }
        } else if (tipoCombustivel == 2)
        {
            if(litrosVendidos > NUMEROBASELITROS){
                double descontoGasolinaMaiorQueNumeroBasePorLitro = PRECOGASOLINA * 0.06; //DESCONTO POR LITRO
                custoGasolina = PRECOGASOLINA - descontoGasolinaMaiorQueNumeroBasePorLitro;
                valorPagar = litrosVendidos * custoGasolina;
                Console.WriteLine($"Valor a ser pago: {valorPagar:F2}");
            } else 
            {
                double descontoGasolinaMenorQueNumeroBase = PRECOGASOLINA * 0.03; //DESCONTO POR LITRO
                custoGasolina = PRECOGASOLINA - descontoGasolinaMenorQueNumeroBase;
                valorPagar = litrosVendidos * custoGasolina; 
                Console.WriteLine($"Valor a ser pago: {valorPagar:F2}");
            }
        } else
        {
            Console.WriteLine("Digite uma opção válida...");
        }
        */
    }
}