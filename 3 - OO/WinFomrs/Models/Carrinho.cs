using System;
using System.Collections.Generic;

namespace WinFomrs.Models
{
    internal class Carrinho
    {
        private static int contador = 1;
        public int Id { get; set; }
        public Models.Cliente Cliente { get; set; }
        public List<Models.Produto> Produtos { get; }
        public double ValorTotal { get; private set; }

        public Carrinho()
        {
            Id = contador++;
            Produtos = new List<Models.Produto>();
        }

        public void AdicionarProduto(Models.Produto produto)
        {
            Produtos.Add(produto);
            ValorTotal += produto.Preco;
        }

        public void RemoverProduto(Models.Produto produto)
        {
            if (Produtos.Remove(produto))
                ValorTotal -= produto.Preco;
        }
    }
}
