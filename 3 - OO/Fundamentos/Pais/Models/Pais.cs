using System;

namespace Pais.Models
{
    internal class Pais
    {
        private string nome;

        //private string capital;
        //private double areaKM2;

        public string Nome
        {
            set
            {
                if (value.Length > 100)
                    throw new ArgumentException("Nome tem mais de 100 caracteres");

                this.nome = value;
            }
            get
            {
                return this.nome;
            }
        }

        public string Capital { get; set; }
        public double AreaKM2 { get; set; }

        public Pais()
        {
        }

        public bool Igual(Pais outroPais)
        {
            return this.Nome == outroPais.Nome
                && this.Capital == outroPais.Capital
                && this.AreaKM2 == outroPais.AreaKM2;
        }

        //public void SetNome(string nome)
        //{
        //    if (nome.Length > 100)
        //        throw new ArgumentException("Nome tem mais de 100 caracteres");

        //    this.nome = nome;
        //}

        //public string GetNome()
        //{
        //    return this.nome;
        //}


        //public void SetCapital(string capital)
        //{
        //    this.capital = capital;
        //}

        //public string GetCapital()
        //{
        //    return this.capital;
        //}

        //public void SetAreaKM2(double areaKM2)
        //{
        //    this.areaKM2 = areaKM2;
        //}

        //public double GetAreaKM2()
        //{
        //    return this.areaKM2;
        //}
    }
}
