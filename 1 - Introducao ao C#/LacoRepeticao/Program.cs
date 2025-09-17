using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoluçãoExercício01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++) 
            {
                if (i % 2 == 0)   
                    continue;  
                Console.WriteLine(i);

/*1) b)  Justifique sua alteração, evidenciando o motivo do erro e o que fez sua correção.
            Fiz a alteração no código pois logo que vi a função break percebi que rodaria
apenas uma vez o código. Analisei então a lógica e vi que estava validando se era par
e se fosse precisaria voltar pro incremento sem mostrar pois o exercicio pede todos os 
impares. Assim eu trocando o break por continue já resolveria o problema de acordo com 
o requisito que era alterar apenas uma linha do código.
 
 
 
 
 */
            }
        }
    }
}
