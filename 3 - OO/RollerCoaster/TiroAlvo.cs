using System;

namespace RollerCoaster
{
    internal sealed class TiroAlvo: BrinquedoNaoEletrico, IBrinquedoAssustador
    {
        public TiroAlvo()
        {
            this.Nome = "Tiro ao alvo";
        }

        public int NivelMedo { get; set; }

        public void Assustar()
        {
            this.NivelMedo = 5;
        }
    }
}
