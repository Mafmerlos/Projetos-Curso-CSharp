using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impressora.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Impressora i1 = new Impressora();
            i1.Imprimir("Matheus");

            i1.Imprimir(1000);

            i1.Imprimir("Matheus", 3);
        }
    }
}
