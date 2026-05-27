using System;
using System.Collections.Generic;

class Exercicio4
{
    static void Main()
    {
        Queue<string> fila = new Queue<string>();
        int opcao = 0;

        while (opcao != 4)
        {
            Console.WriteLine("\n--- Fila de Atendimento ---");
            Console.WriteLine("1. Adicionar cliente");
            Console.WriteLine("2. Atender próximo cliente");
            Console.WriteLine("3. Ver tamanho da fila");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Write("Digite o nome do cliente: ");
                string nome = Console.ReadLine();
                fila.Enqueue(nome);
                Console.WriteLine("Cliente entrou na fila.");
            }
            else if (opcao == 2)
            {
                if (fila.Count > 0)
                {
                    string clienteAtendido = fila.Dequeue();
                    Console.WriteLine($"Atendendo cliente: {clienteAtendido}");
                }
                else
                {
                    Console.WriteLine("A fila está vazia.");
                }
            }
            else if (opcao == 3)
            {
                Console.WriteLine($"Clientes na fila: {fila.Count}");
            }
        }
    }
}
