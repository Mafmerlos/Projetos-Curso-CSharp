using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario.Interface
{
    internal interface IFuncionario
    {
        string Nome { get; }
        double Salario { get; }
        void ReajustarSalario(double percentual);

    }
}
