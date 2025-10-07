using System;

namespace Loja.Models
{
    internal class Porta
    {
        private bool aberta;
        private string cor;
        public Porta()
        {
            this.aberta = false;
            this.cor = "branca";
        }

        public void Abrir()
        {
            this.aberta = true;
        }

        public void Fechar()
        {
            this.aberta = false;
        }

        //public void Pintar(string cor)
        //{
        //    this.cor = cor;
        //}
    }

}
