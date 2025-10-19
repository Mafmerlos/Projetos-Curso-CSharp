using System;

namespace RollerCoaster
{
    internal class Bilheteria
    {
        private static int contador;
        public int Id { get; }
        
        public Bilheteria()
        {
            Id = ++contador;
        }
    }
}
