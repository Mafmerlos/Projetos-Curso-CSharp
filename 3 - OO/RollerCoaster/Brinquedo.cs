using System;

namespace RollerCoaster
{
    internal abstract class Brinquedo
    {
        private static int codigo;

        public int Id { get; }
        public string Nome {get; set;}
        protected int idadeMinima;
        private bool aberto;

        public Brinquedo()
        {
            this.Id = ++codigo;
            this.Nome = "";
            this.idadeMinima = 0;
            this.aberto = false;
        }

        public virtual void Abrir()
        {
            this.aberto = true;
        }

        public virtual void Fechar()
        {
            this.aberto = false;
        }

        public bool IsAberto()
        {
            return this.aberto;
        }
    }
}
