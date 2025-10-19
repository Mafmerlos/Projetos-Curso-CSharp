using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livro.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro1 = new Livro("O Pequeno Príncipe", "Antoine de Saint-Exupéry");
            Console.WriteLine(livro1.ExibirDados()); 

            Livro livro2 = new Livro();
            Console.WriteLine(livro2.ExibirDados());

        }
    }
}
