using System;

namespace RollerCoaster
{
    internal class Funcionario: Pessoa, IAcessoParque
    {
        public double Salario { get; set; } 

        public Funcionario() { }

        public Funcionario(double salario)
        {
            Salario = salario;
        }
    }
}
