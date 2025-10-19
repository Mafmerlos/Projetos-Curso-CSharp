using System;
using Livro.Interface;

namespace Livro.Models
{
    internal class Livro : ILivro
    {
        public string Titulo { get; private set; }
        public string Autor { get; private set; }

        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }

        public Livro()
        {
            Titulo = string.Empty;
            Autor = string.Empty;
        }

        public string ExibirDados()
        {
            {
                return $"Livro: {Titulo} escrito por {Autor}";
            }
        }
    }
}
