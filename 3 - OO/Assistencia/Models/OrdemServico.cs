using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistencia.Models
{
    internal class OrdemServico
    {
        public int NumeroOS { get; set; }
        public string NomeCliente { get; set; }
        public DateTime DataAbertura { get; set; }
        public List<Produto> Produtos { get; }

        public OrdemServico()
        {
            DataAbertura = DateTime.Now;
            Produtos = new List<Produto>();
        }
       

        public OrdemServico(int numeroOrdem, string nomeCliente)
        {
            Produtos = new List<Produto>();
            NumeroOS = numeroOrdem;
            NomeCliente = nomeCliente;
            DataAbertura = DateTime.Now;
        }


        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }

        public void RemoverProduto(Produto produto)
        {
            Produtos.Remove(produto);

        }

        public string Imprimir()
        {
           
            StringBuilder os = new StringBuilder();

            os.Append("===========================================\r\n");
            os.Append("Início OS\r\n");
            os.Append("===========================================\r\n");
            os.Append($"Ordem: {NumeroOS}\r\n");
            os.Append($"Cliente: {NomeCliente}\r\n");
            os.Append($"Data de Abertura: {DataAbertura:dd/MM/yyyy}\r\n");
            os.Append("-------------------------------------------\r\n");
            os.Append("Produtos da OS - defeito:\r\n");
           
            foreach (Produto produto in Produtos)
            {
                os.Append( $"{produto.Nome} {produto.Categoria} - {produto.DefeitoRelatado}\n");
            }
            os.Append("===========================================\r\n");
            os.Append($"Total de produtos: {Produtos.Count}\r\n");
            os.Append("===========================================\r\n");
            os.Append("Fim OS\r\n");
            os.Append("===========================================\r\n");


            

            return os.ToString();
        }

       
    }
}
