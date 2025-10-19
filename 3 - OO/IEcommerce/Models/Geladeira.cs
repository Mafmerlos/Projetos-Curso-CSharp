using System;
using System.Collections.Generic;
using IEcommerce.Interfaces;

namespace IEcommerce.Models
{
    internal class Geladeira : IGeladeira
    {
        public double Temperatura { get; private set; }

        public double Capacidade { get;  set; }

        public List<Interfaces.IProdutoGeladeira> Produtos { get; }

        public Geladeira()
        {
            Produtos = new List<Interfaces.IProdutoGeladeira>();
        }

        public void AdicionarProduto(Interfaces.IProdutoGeladeira produto)
        {
            /*if (produto is ProdutoGiftCard)
                throw new ArgumentException("Produto não pode entrar na geladeira!");*/

            Produtos.Add(produto);
        }

        public void AumentarTemperatura()
        {
            Temperatura++;
        }

        public void DiminuirTemperatura()
        {
            Temperatura--;
        }

        public void RemoverProduto(Interfaces.IProdutoGeladeira produto)
        {
            Produtos.Remove(produto);
        }
    }
}
