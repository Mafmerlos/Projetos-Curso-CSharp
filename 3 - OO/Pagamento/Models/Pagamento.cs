using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamento.Models
{
    internal abstract class Pagamento
    {
        public double Valor { get; set; }
        public DateTime Data { get; set; }

        //public virtual bool Validar() { return true; } 
        public abstract bool Validar();
    }
}
