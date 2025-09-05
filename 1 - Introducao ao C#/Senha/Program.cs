using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Faça um programa que solicite uma senha para o usuário.
 * Caso a senha seja igual à 123voltojah o programa deve exibir a mensagem "Acesso Total".
 * Caso contrário o programa deve exibir a mensagem "Acesso Negado".
 * Se a senha informada pelo usuário possuir menos de 4 caracteres, o programa deve exibir a mensagem "Senha deve ter mais de 3 caracteres".
 */

namespace Senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string SENHACORRETA = "123voltojah";
            const int TAMANHOMINIMOSENHA = 4;

            Console.WriteLine("Digite uma senha: ");
            string senha = Console.ReadLine();

            if(senha.Length < TAMANHOMINIMOSENHA)
                Console.WriteLine("Senha deve ter mais de 3 caracteres");
            else if (senha == SENHACORRETA)
                Console.WriteLine("Acesso total");
            else
                Console.WriteLine("Acesso negado");

            Console.WriteLine("Digite ENTER para encerrar...");
            Console.ReadLine();
}


        }
    }
