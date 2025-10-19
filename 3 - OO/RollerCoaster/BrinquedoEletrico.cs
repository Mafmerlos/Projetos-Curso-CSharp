using System;

namespace RollerCoaster
{
    internal abstract class BrinquedoEletrico: Brinquedo
    {
        private bool ligado;
                
        public BrinquedoEletrico()
        {
            this.Nome = "Brinquedo Elétrico";
            this.ligado = false;
            this.idadeMinima = 6;
        }

        public override void Abrir()
        {            
            base.Abrir();
            this.Ligar();
        }

        public override void Fechar()
        {
            base.Fechar();
            this.Desligar();
        }

        private void Ligar()
        {
            this.ligado = true;
        }

        private void Desligar()
        {
            this.ligado = false;
        }

        private bool IsLigado()
        {
            return this.ligado;
        }
    }
}
