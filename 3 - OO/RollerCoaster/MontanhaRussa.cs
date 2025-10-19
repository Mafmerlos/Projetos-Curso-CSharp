using System;

namespace RollerCoaster
{
    internal class MontanhaRussa: BrinquedoEletrico, IBrinquedoAssustador, IBrinquedoRadical
    {
        public double AlturaMinima { get; }
        public int NivelMedo { get; set; }
        public int NivelAdrenalina { get; set; }

        public MontanhaRussa()
        {
            this.Nome = "Montanha Russa";
            this.AlturaMinima = 1.5;
           
            this.idadeMinima = 10;
        }

        public void Assustar()
        {
            this.NivelMedo = 10;
        }
    }
}
