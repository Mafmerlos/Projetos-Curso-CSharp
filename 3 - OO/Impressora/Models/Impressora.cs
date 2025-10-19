using Impressora.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Impressora.Models
{
    internal class Impressora:IImpressora
    {
        public string Imprimir(string texto)
        {
            return texto;
        }

        public string Imprimir(int numero)
        {
            return numero.ToString(); //Pode chamar o outro 
        }

        public string Imprimir(string texto, int numero) {

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < numero; i++)
            {
                sb.Append(texto);
            }

            return sb.ToString();
           

        }
    }
}