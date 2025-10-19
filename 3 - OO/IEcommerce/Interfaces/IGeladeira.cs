using System;
using System.Collections.Generic;

namespace IEcommerce.Interfaces
{
    internal interface IGeladeira
    {
        double Temperatura { get; }
        double Capacidade { get; set; }

        List<Interfaces.IProdutoGeladeira> Produtos { get; }
        void AumentarTemperatura();
        void DiminuirTemperatura();
        void AdicionarProduto(Interfaces.IProdutoGeladeira produto);
        void RemoverProduto(Interfaces.IProdutoGeladeira produto);
    }
}
