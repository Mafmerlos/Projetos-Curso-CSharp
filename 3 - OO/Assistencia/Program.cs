using Assistencia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crie um programa em C# que simule o gerenciamento básico de uma assistência técnica.
/*
Cadastrar produtos com os seguintes campos:
Id (inteiro)
Nome (string)
Categoria (string)
Defeito relatado (string)

Criar uma Ordem de Serviço (OS), onde produtos cadastrados podem ser adicionados junto com 
número da OS : int
nome do cliente: string
data de abertura: date
adicionar produtos (produto): void
remover produtos (produto): void

Imprimir os dados da Ordem de Serviço no console, mostrando:
Dados da OS (número, cliente, data);
Lista dos produtos incluídos com seus detalhes;
Total de produtos cadastrados na OS.
===========================================
Início OS
===========================================
Ordem: 1023
Cliente: Maria Oliveira
Data de Abertura: 07/10/2025
-------------------------------------------
Produtos da OS - defeito:
-------------------------------------------
Notebook Dell XPS - Tela não liga
HP 2050 Periférico - Puxa duas folhas
-------------------------------------------
Total de produtos: 2
===========================================
Fim OS
===========================================
 */


namespace Assistencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1, "Notebook Dell XPS", "Notebook", "Tela não liga");
            Produto p2 = new Produto(2, "HP 2050 ", "Periférico", "Puxa duas folhas");
            Produto p3 = new Produto(3, "Notebook Asus", "Notebook", "Problema com memória");
            
            Models.OrdemServico os1 = new Models.OrdemServico();
            os1.AdicionarProduto(p1);

            Models.OrdemServico os2 = new Models.OrdemServico();
            os2.AdicionarProduto(p2);
            os2.AdicionarProduto(p3);

            Console.WriteLine(os1.Imprimir());
            Console.WriteLine(os2.Imprimir());


        }
    }
}
