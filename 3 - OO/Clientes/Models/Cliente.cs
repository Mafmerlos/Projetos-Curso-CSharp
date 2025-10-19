using System;
using Clientes.Interfaces;

namespace Clientes.Models
{
    internal class Cliente : IClientes
    {
        private static int contador = 0;
        public int Codigo {  get; private set; }
        public int Idade { get;  set; }
        public string Nome { get;  set; }

        public Cliente() {
            Codigo = contador++;
            Nome = string.Empty;
            Idade = 0;
        
        }

        public string ExibirDados () {
            return $"Código: {Codigo}, Nome: {Nome}, Idade: {Idade}";
        }
       
    }
}
