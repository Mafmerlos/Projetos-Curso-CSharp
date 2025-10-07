using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistencia.Models
{
    internal class Produto
    {
        public int Id { get;  set; }
        public string Nome { get; set; }
        public string Categoria { get;  set; }
        public string DefeitoRelatado { get; set; }

        public Produto(int id, string nome, string categoria, string defeitoRelatado) {
            Id = id;
            Nome = nome;
            Categoria = categoria;
            DefeitoRelatado = defeitoRelatado;
        }

        

    }
}
