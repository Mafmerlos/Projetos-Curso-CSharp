using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas
{
    internal class Contas
    {
        double valor = 0;
        public List<Conta> ListaContas {  get; }
        public double ValorTotal { get; private set; }

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
            foreach (Conta conta in ListaContas)
            {
                valor += conta.Valor;
            }
            return valor;
        }
    }
}
