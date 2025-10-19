using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    internal class Program
    {
        static void Main(string[] args){
            Models.Funcionario funcionario = new Models.Funcionario("Matheus", 10000);

            Console.WriteLine($"O salário do {funcionario.Nome} é {funcionario.Salario}");
            funcionario.ReajustarSalario(10);
            Console.WriteLine($"O salário do {funcionario.Nome} é {funcionario.Salario}");

        }
    }
}
