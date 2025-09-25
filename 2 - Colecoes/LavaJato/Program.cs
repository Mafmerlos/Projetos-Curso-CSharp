using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Lavar Veículos
 * 
 * Cada vez que chega um veículo, este veículo recebe um número sequencial
 * e fica numa fila dentro do pátio para ser lavado. (FIFO) => QUEUE<int>
 * 
 * Conforme o veículo é lavado, ele é colocado em um galpão de entrega. LIST<int>
 *
 * Para entregá-lo, o cliente fornece o número do veículo. => Procurar o número do carro LIST<int>
 * Se o número existir, o veículo é entregue, caso contrário ele ainda está no processo de lavagem.
 * 
 * Opções
 * 1 - Receber carro para lavar
 * 2 - Lavar
 * 3 - Entregar carro => solicita número
 * 4 - Encerrar programa => fila e lista (vazia) * 
 * 
 *  menu - ok
 *  opção 1 - ok
 *  opção 2 - ok
 *  opção 3 - ok
 *  
 */



namespace LavaJato
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
