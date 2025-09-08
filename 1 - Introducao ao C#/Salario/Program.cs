using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Faça um Programa que pergunte quanto você ganha por hora 
 e o número de horas trabalhadas no mês. 
 Calcule e mostre o total do seu salário no referido mês, 
 sabendo-se que são descontados 11% para o Imposto de Renda, 
 8% para o INSS e 5% para o sindicato,
Assim, o programa de exibir:
    salário bruto = ganho por hora * horas trabalhadas no mês
    quanto pagou ao IR
    quanto pagou ao INSS
    quanto pagou ao Sindicato
    Salário líquido = Salário Bruto - Descontos

dessa forma:
+ Salário Bruto : R$  
- IR (11%) : R$
- INSS (8%) : R$
- Sindicato (5%) : R$
= Salário Líquido : R$

 */

namespace Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double salarioHora = 0.0, horasTrabalhadasMes = 0.0, salarioBrutoMes = 0.0,
                descontoImpostoDeRenda = 0.0, descontoInss = 0.0, descontoSindicato = 0.0,
                salarioliquido = 0.0;


            Console.WriteLine("Digite quanto você ganha por hora: ");
            salarioHora = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantas horas você trabalhou no mês: ");
            horasTrabalhadasMes = double.Parse(Console.ReadLine());

            salarioBrutoMes = salarioHora * horasTrabalhadasMes;
            descontoImpostoDeRenda = salarioBrutoMes * 0.11;
            descontoInss = salarioBrutoMes * 0.08;
            descontoSindicato = salarioBrutoMes * 0.05;
            salarioliquido = salarioBrutoMes - descontoImpostoDeRenda - descontoInss - descontoSindicato;

            Console.WriteLine($"+ Salário bruto: R$ {salarioBrutoMes} ");
            Console.WriteLine($"- IR (11%) : R$ {descontoImpostoDeRenda} ");
            Console.WriteLine($"- INSS (8%) : R$ {descontoInss}");
            Console.WriteLine($"- Sindicato (5%) : R$ {descontoSindicato}");
            Console.WriteLine($"= Salário líquido: R$ {salarioliquido}");

            Console.WriteLine("Digite ENTER para encerrar o programa");
            Console.ReadLine();

        }
    }
}
