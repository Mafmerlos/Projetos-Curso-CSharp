using System;

namespace WinFomrs.Models
{
    internal class Cliente
    {
        public static int contador = 0;
        public int Id { get;}
        public string Nome { get; set; }

        public Cliente()
        {
            Id = ++contador;
        }
    }
}
