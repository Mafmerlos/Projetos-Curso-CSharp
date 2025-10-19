using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario.Models
{
    internal class Funcionario
    {
        public string Nome {  get;  private set; }
        public double Salario { get; private set; }

        public Funcionario(string nome, double salario) {
            this.Nome = nome;
            Salario = salario;
        }

        public void ReajustarSalario(double percentual)
        {
            if (percentual > 0)
            {
                Salario += Salario * (percentual / 100);
            }
        }

        //Perguntas sobre o código
        /*
         * Por que o set foi declarado como private nas propriedades?
         * Resposta: O set foi declarado como private nas propriedas para só poder ser alterado
         * dentro da própria classe e nao fora dela. 
         * 
         * Defina, em uma palavra, o princípio da POO que foi aplicado nesse controle de acesso?
         * Encapsulamento
         * 
         * O que mudaria no controle do Salario se ele tivesse apenas set público?
         * Qualquer um poderia ter acesso fora da classe e acabando com a segurança do código
         * além de deixar o acesso facilitado para quem não tem "permissão".
         * 
         */


    }
}
