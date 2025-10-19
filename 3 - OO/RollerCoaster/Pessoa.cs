using System;

namespace RollerCoaster
{
    internal class Pessoa
    {
        private static int contador;
        public int Id { get;}
        public string Nome { get; set; }

        public Pessoa() 
        {
            Id = ++contador;
            Nome = string.Empty;
        }
    }
}
