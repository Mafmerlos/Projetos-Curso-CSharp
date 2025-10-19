using System;
using IEcommerce.Interfaces;

namespace IEcommerce.Models
{
    internal class ProdutoLaticinio : Produto, IProdutoLaticinio, IProdutoGeladeira
    {
        public double QuantidadeLeite { get; private set; }

        public void AdicionarLeite(double quantidade)
        {
            QuantidadeLeite += quantidade;
        }

        public void RemoverLeite(double quantidade)
        {
            QuantidadeLeite -= quantidade;
        }
    }
}
