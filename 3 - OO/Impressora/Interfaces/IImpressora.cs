using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impressora.Interfaces
{
    internal interface IImpressora
    {
        string Imprimir(string texto);
        string Imprimir(int numero);
        string Imprimir(string texto,int numero);

    }
}
