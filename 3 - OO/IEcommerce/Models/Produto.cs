using System;
using IEcommerce.Interfaces;

namespace IEcommerce.Models
{
    internal abstract class Produto:IProduto
    {
        public int Id { get; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public double Preco { get; set; }

        public void AplicarDesconto(double percentualDesconto)
        {
            if (percentualDesconto < 0 || percentualDesconto > 100)
                throw new ArgumentException("Erro no percentual de desconto! Não está entre 0 e 100."); //interromper o fluxo do programa.

            Preco *= 1 - percentualDesconto / 100;
        }

        public void AumentarPreco(double percentualAumento)
        {
            if (percentualAumento <= 0)
                throw new ArgumentException("Erro no percentual de aumento! Menor ou igual a 0."); //interromper o fluxo do programa.

            Preco *= 1 + percentualAumento / 100;
        }

        public void Descartar() 
        {
        }
    }
}
