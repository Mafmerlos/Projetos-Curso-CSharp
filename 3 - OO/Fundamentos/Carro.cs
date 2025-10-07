using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    // public / internal / private => modificadores de acesso

    public class Carro
    {
        public string Cor { get; set; }
        public int Tamanho { get; set; }
        public int QuantidadeDePneus { get; set; }
        public bool ArCondicionado { get; set; }
        public double Velocidade { get; private set; }

        public Carro()
        {

        }

        public void Acelerar()
        {
            this.Velocidade++;
            //return;
        }

        public void Frear()
        {
            if (this.Velocidade > 0)
                this.Velocidade--;
        }

        public bool EstaParado()
        {
            return this.Velocidade == 0;
        }
    }
}