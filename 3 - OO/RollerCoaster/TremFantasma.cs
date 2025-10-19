using System;

namespace RollerCoaster
{
    internal class TremFantasma : BrinquedoEletrico, IBrinquedoAssustador
    {

        public TremFantasma()
        {
            this.Nome = "Trem Fantasma Assustador";
        }
        public int NivelMedo { get; set; }

        public void Assustar()
        {
            this.NivelMedo = 15;
        }
    }
}
