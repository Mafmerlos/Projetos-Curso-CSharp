using System;

namespace Ecommerce.Models
{
    internal class Produto
    {
        private static int contador = 0; //não tem referência com o objeto (alocado uma única vez - classe)
        public int Id { get; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public double Preco {  get; private set; }

        public Produto(string nome, string categoria, double preco)
        {
            Id = ++contador;
            Nome = nome;
            Categoria = categoria;
            Preco = preco;
        }

        public void AplicarDesconto(double percentualDesconto)
        {
            if (percentualDesconto < 0 || percentualDesconto > 100 )
                throw new ArgumentException("Erro no percentual de desconto! Não está entre 0 e 100."); //interromper o fluxo do programa.

            Preco *= 1 - percentualDesconto / 100;
        }

        public void AumentarPreco(double percentualAumento)
        {
            if (percentualAumento <= 0)
                throw new ArgumentException("Erro no percentual de aumento! Menor ou igual a 0."); //interromper o fluxo do programa.

            Preco *= 1 + percentualAumento / 100;
        }
    }
}
