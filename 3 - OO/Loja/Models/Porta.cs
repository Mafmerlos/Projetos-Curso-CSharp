using System;

namespace Loja.Models
{
    internal class Porta
    {
        public bool Aberta {  get; private set; }
        public string Cor {  get; private set; }
        
        public Porta()
        {
            Aberta = false;
            Cor = "branca";
        }

        public Porta(bool aberta,string cor)
        {
            this.Aberta = aberta; //this quando não colocado funciona por debaixo dos panos
            Cor = cor;

        }

        public void Abrir()
        {
            Aberta = true;
        }

        public void Fechar()
        {
            Aberta = false;
        }

        public void Pintar(string cor)
        {
            this.Cor = cor;
        }
    }
}
