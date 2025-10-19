using System;

namespace IEcommerce.Interfaces
{
    internal interface IProdutoLaticinio
    {
        double QuantidadeLeite { get; }

        void AdicionarLeite(double quantidade);

        void RemoverLeite(double quantidade);
    }
}
