using System;

namespace RollerCoaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parque parque1 = new Parque();
            parque1.Nome = "Uaaaaauuuuuuuuu";

            for (int i = 0; i < 3; i++)
            {
                parque1.AdicionarBrinquedo(new Carrossel());
            }

            for (int i = 0; i < 5; i++)
            {
                parque1.AdicionarBrinquedo(new MontanhaRussa());
            }
                                    
            TrombaTromba tt1 = new TrombaTromba();            
            TrombaTromba tt2 = new TrombaTromba();
            TrombaTromba tt3 = new TrombaTromba();

            PulaPula pp1 = new PulaPula();
            
            TiroAlvo ta1 = new TiroAlvo();
            TiroAlvo ta2 = new TiroAlvo();
                       
            
            parque1.AdicionarBrinquedo(tt1);
            parque1.AdicionarBrinquedo(tt2);
            parque1.AdicionarBrinquedo(tt3);

            parque1.AdicionarBrinquedo(ta1);
            parque1.AdicionarBrinquedo(ta2);

            parque1.AdicionarBrinquedo(pp1);
            
            parque1.Abrir();

            tt1.Fechar();
            ta2.Fechar();


            parque1.FecharBrinquedo(3);

            parque1.Fechar();

            
            
            Parque parque2 = new Parque();
            parque2.Nome = "Viiiiiiiiiiiiiiiixiiiiiii";

            for (int i = 0; i < 3; i++)
            {
                parque2.AdicionarBrinquedo(new Carrossel());
            }

            for (int i = 0; i < 2; i++)
            {
                parque2.AdicionarBrinquedo(new MontanhaRussa());
            }            

            parque2.Abrir();
            
            Bilheteria b1 = new Bilheteria();
            parque2.AdicionarBilheteria(b1);

            //for (int i = 0; i < 50; i++)
            //{
            //    parque2.AdicionarPessoas(new Pessoa());
            //}

            //parque2.AdicionarPessoas(new Pessoa());

            parque2.AdicionarPessoas(new Funcionario());
            parque2.AdicionarPessoas(new Auditor());
            parque2.AdicionarPessoas(new Visitante());

            parque2.AdicionarPessoas(new Gerente());

            parque2.Fechar();

        }
    }
}
