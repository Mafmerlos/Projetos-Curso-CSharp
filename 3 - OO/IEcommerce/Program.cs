using IEcommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEcommerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geladeira g1 = new Geladeira();

            //Produto p1 = new Produto();
            
            ProdutoDiet pd1 = new ProdutoDiet();
            ProdutoLaticinio pl1 = new ProdutoLaticinio();
            
            ProdutoGiftCard pgc1 = new ProdutoGiftCard();

            //g1.AdicionarProduto(p1); // estranho
            
            g1.AdicionarProduto(pd1);
            g1.AdicionarProduto(pl1);

            //g1.AdicionarProduto(pgc1); // estranho
        }
    }
}
