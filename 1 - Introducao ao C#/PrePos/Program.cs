using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrePos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 89;

            int valorPos = contador++;
            //valorPos = contador;
            //contador++;
            Console.WriteLine(contador);
            Console.WriteLine(valorPos);

            int valorPre = ++contador;
            //contador++;
            //valorPre = contador;
            Console.WriteLine(contador);
            Console.WriteLine(valorPre);

            valorPre = contador++ * 2 + 28;

            contador--;
            --contador;
        }
    }
}
