using System;
using IEcommerce.Interfaces;

namespace IEcommerce.Models
{
    internal class ProdutoDiet : Produto, IProdutoDiet, IProdutoGeladeira
    {
        public string ComponentesDiet { get; set; }
    }
}
