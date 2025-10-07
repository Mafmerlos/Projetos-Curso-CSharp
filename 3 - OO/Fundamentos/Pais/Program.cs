using System;

namespace Pais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Models.Pais brasil = new Models.Pais();
            brasil.Nome = "Brasil";
            brasil.Capital = "Brasília";
            brasil.AreaKM2 = 8515767;

            Models.Pais argentina = new Models.Pais();
            argentina.Nome = "Argentina";
            argentina.Capital = "Buenos Aires";
            argentina.AreaKM2 = 2780400;

            argentina.Igual(brasil);

            //Mostrar o nome do objeto brasil no console?
            Console.Write($"O nome do objeto brasil é {brasil.Nome}");
        }
    }
}
