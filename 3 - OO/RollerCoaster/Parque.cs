using System;
using System.Collections.Generic;

namespace RollerCoaster
{
    internal class Parque: IParque
    {
        public string Nome { get; set; }
        private List<Brinquedo> brinquedos;
        private List<IAcessoParque> pessoas;
        private List<Bilheteria> bilheterias;
        
        public Parque()
        {
            this.Nome = "";
            this.brinquedos = new List<Brinquedo>();
            this.pessoas = new List<IAcessoParque>();
            this.bilheterias = new List<Bilheteria>();
        }

        public void AdicionarBrinquedo(Brinquedo brinquedo)
        {
            this.brinquedos.Add(brinquedo);
        }

        //public bool AdicionarPessoas(Pessoa pessoa)
        //{
        //    if (pessoa is Funcionario 
        //        || pessoa is Auditor
        //        || pessoa is Visitante)
        //    {
        //        this.pessoas.Add(pessoa);
        //        return true;
        //    }
        //    return false;            
        //}

        public void AdicionarPessoas(IAcessoParque pessoa)
        {
            this.pessoas.Add(pessoa);
        }

        public void AdicionarBilheteria(Bilheteria bilheteria)
        {
            this.bilheterias.Add(bilheteria);
        }

        public void Abrir()
        {
            foreach (var item in brinquedos)
            {
                item.Abrir();
            }            
        }

        public void Fechar()
        {
            foreach (var item in brinquedos)
            {
                item.Fechar();
            }
        }

        public void FecharBrinquedo(int id)
        {
            foreach(var item in brinquedos)
            {                
                if (item.Id == id)
                {
                    item.Fechar();
                    break;
                }
            }
        }
    }
}
