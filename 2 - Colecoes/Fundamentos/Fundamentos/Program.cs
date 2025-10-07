using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Moto moto = new Moto();
            moto.id = 1;
            moto.nome = "XJ6";




            Personagem personagem1 = new Personagem();
            personagem1.id = 1;
            personagem1.nome = "Matheus";
            personagem1.idade = 21;
            personagem1.corDoCabelo = "Preto";

            Personagem personagem2 = new Personagem();
            personagem2.id = 1;
            personagem2.nome = "Matheus";
            personagem2.idade = 21;
            personagem2.corDoCabelo = "Preto";

            Personagem personagem3 = new Personagem();
            personagem3.id = 1;
            personagem3.nome = "Matheus";
            personagem3.idade = 21;
            personagem3.corDoCabelo = "Preto";


        }
    }
}
