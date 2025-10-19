using System;
using System.Collections.Generic;

namespace Ecommerce.Models
{
    internal class Carrinho
    {
        private static int contador = 1;
        public int Id { get; set; }
        public Models.Cliente Cliente { get; set; }
        public List<Models.ItemCarrinho> Produtos { get; }
        public double ValorTotal { get; private set; }

        public double Desconto { get; private set;}

        public Carrinho()
        {
            Id = contador++;
            Produtos = new List<Models.ItemCarrinho>();
        }

        public void AdicionarProduto(Models.Produto produto)
        {
            Models.ItemCarrinho itemCarrinho = new Models.ItemCarrinho(); //composição
            CopiarDadosProduto(produto, itemCarrinho);
            
            Produtos.Add(itemCarrinho);
            ValorTotal += itemCarrinho.Preco;
        }

        public void RemoverProduto(Models.Produto produto)
        {
            Models.ItemCarrinho itemCarrinho = new Models.ItemCarrinho(); //composição
            CopiarDadosProduto(produto, itemCarrinho);

            if (Produtos.Remove(itemCarrinho))
                ValorTotal -= itemCarrinho.Preco;
        }

        private void CopiarDadosProduto(Models.Produto produto, Models.ItemCarrinho itemCarrinho)
        {
            itemCarrinho.Id = produto.Id;
            itemCarrinho.Nome = produto.Nome;
            itemCarrinho.Categoria = produto.Categoria;
            itemCarrinho.Preco = produto.Preco;
        }

        public void AplicarDesconto(string Cupom)
        {
            Desconto = ValorCupom(Cupom); //pensando que o valor do desconto é somente o valor do CUPOM.
            ValorTotal -= Desconto;
        }

        private double ValorCupom(string Cupom)
        {
            //Validação do CUPOM - se existe, dentro do prazo.....
            //e retorna o valor do cupom
            return 0; //valor do cumpom... 0 foi só para o método funcionar.
        }
    }

}
