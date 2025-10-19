using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Clientes.Interfaces
{
    internal  interface IClientes
    {
        int Codigo { get;  }
        string Nome { get; set; }
        int Idade { get; set; }

        string ExibirDados();

    }
}
