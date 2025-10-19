using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamento.Models
{
    internal class CartaoDeCredito : Pagamento
    {

        public override bool Validar()
        {
            throw new NotImplementedException();
        }

    }
}
