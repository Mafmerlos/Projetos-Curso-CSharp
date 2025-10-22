using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas
{
    internal class Conta
    {
        public DateTime Data { get; }
        public double Valor { get; set; }

        public Conta(DateTime data, double valor)
        {
            this.Data = data;
            this.Valor = valor;
        }
    }
}