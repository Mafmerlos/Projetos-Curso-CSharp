using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Especie.Models
{
    internal abstract class Animalia
    {
        public string Nome { get; protected set; }

        public virtual string GetDescricao()
        {
            return "Animalia";
        }
    }
}
