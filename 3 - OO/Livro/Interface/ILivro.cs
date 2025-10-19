using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livro.Interface
{
    internal interface ILivro
    {
        string Titulo { get; }
        string Autor {  get; }

        string ExibirDados();
    }
}
