using Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioContas
{
    internal class Contas
    {
            
        public List<Conta> ListaContas { get; }

        public Contas() 
        {
            ListaContas = new List<Conta>();
        }

        public void Adicionar(Conta conta)
        {
            ListaContas.Add(conta);
        }

        public double GetValorTotal()
        {
            double valorTotal = 0;
            foreach (Conta conta in ListaContas)
            {
                valorTotal += conta.Valor;
            }
            return valorTotal;
        }
    }
}
