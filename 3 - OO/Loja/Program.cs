using System;

namespace Loja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Models.Porta p1 = new Models.Porta(); //A102
            p1.Abrir();
            p1.Fechar();

            p1.Pintar("amarelo");
            p1.Pintar("azul");
            p1.Pintar("vermelho");

            Models.Porta p2 = new Models.Porta(); //B120
            p2.Abrir();
            //p2.Pintar("roxo");

            Models.Porta p3 = p1;
            p3.Abrir();

            p1.Pintar("verde");

            Models.Porta p4 = new Models.Porta(); //C200
            p4.Abrir();
        }
    }
}
