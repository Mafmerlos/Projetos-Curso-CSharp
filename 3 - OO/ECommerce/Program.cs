using Ecommerce.Models;
using System;

namespace Ecommerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Models.Produto p1 = new Models.Produto("Arroz", "Comida", 20);
            p1.AumentarPreco(10);

            Models.Produto p2 = new Models.Produto("TV", "Eletronico", 5600);
            
            Models.Produto p3 = new Models.Produto("Cachaça", "Bebida", 9.5);

            //p3.AplicarDesconto(150);

            Models.Cliente c1 = new Models.Cliente();
            c1.Nome = "Joca";

            Models.Cliente c2 = new Models.Cliente();
            c2.Nome = "Zeca";

            Models.Carrinho car1 = new Carrinho();
            car1.Cliente = c1;
            car1.AdicionarProduto(p1);
            car1.AdicionarProduto(p3);

            //car1.RemoverProduto(p1);
            //car1.RemoverProduto(p2);

            Console.WriteLine("--Dados do carrinho de compras--");
            Console.WriteLine($"Id:{car1.Id}");

            Console.WriteLine("Id - Nome - Valor");
            foreach (var item in car1.Produtos)
            {
                Console.WriteLine($"{item.Id} - {item.Nome} - {item.Preco}");
            }

            Console.WriteLine($"Valor Total:{car1.ValorTotal}");

            p1.AplicarDesconto(10); //CUIDADO - UM DESCONTO NO PRODUTO NÃO PODE AFETAR OS PRODUTOS QUE JÁ ESTÃO DENTRO DO CARRINHO.

            car1.AplicarDesconto("EHHOJE");

            car1 = null;
        }
    }
}
