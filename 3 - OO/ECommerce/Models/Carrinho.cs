using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    internal class Carrinho
    {
        public int Id { get; set; }
        public Models.Cliente Cliente { get; set; }
        public List<Models.Produto> Produtos { get; }
    }
}
