using System;

namespace Loja.Models
{
    internal class Porta
    {
        private bool aberta;
        private string cor;
        public Porta()
        {
            aberta = false;
            cor = "branca";
        }

        public void Abrir()
        {
            aberta = true;
        }

        public void Fechar()
        {
            aberta = false;
        }

        public void Pintar(string cor)
        {
            this.cor = cor;
        }
    }
}
