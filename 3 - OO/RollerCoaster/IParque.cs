using System;

namespace RollerCoaster
{
    internal interface IParque
    {
        string Nome { get; set; }
        void AdicionarBrinquedo(Brinquedo brinquedo);
        void AdicionarPessoas(IAcessoParque pessoa);
        void AdicionarBilheteria(Bilheteria bilheteria);
        void Abrir();
        void Fechar();
        void FecharBrinquedo(int id);
    }
}
