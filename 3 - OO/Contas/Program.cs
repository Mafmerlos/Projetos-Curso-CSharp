using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta(DateTime.Now, 1000); 
            Contas contas = new Contas();

            contas.Adicionar(conta1);
            contas.GetValorTotal();

                
        }
    }
}
