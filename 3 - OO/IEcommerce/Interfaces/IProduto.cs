using System;

namespace IEcommerce.Interfaces
{
    internal interface IProduto
    {
        int Id { get; }
        string Nome { get; set; }
        string Categoria { get; set; }
        double Preco { get; set; }

        void AplicarDesconto(double percentualDesconto);
        void AumentarPreco(double percentualAumento);

    }
}
