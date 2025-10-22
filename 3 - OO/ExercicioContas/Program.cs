using Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioContas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta(DateTime.Now, 1000);
            Conta conta2 = new Conta(DateTime.Now, 3000);
            Contas contas = new Contas();

            contas.Adicionar(conta1);
            contas.Adicionar(conta2);
            contas.GetValorTotal();

            
            Console.WriteLine(contas.GetValorTotal());
        }
    }
}
