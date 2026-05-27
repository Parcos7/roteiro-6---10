using System;
using System.Collections.Generic;

class Exercicio1
{
    static void Main()
    {
        List<string> listaCompras = new List<string>();
        int opcao = 0;

        while (opcao != 5)
        {
            Console.WriteLine("\n--- Lista de Compras ---");
            Console.WriteLine("1. Adicionar item");
            Console.WriteLine("2. Remover item");
            Console.WriteLine("3. Listar itens");
            Console.WriteLine("4. Quantidade total");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Write("Digite o nome do item para adicionar: ");
                string item = Console.ReadLine();
                listaCompras.Add(item);
                Console.WriteLine("Item adicionado!");
            }
            else if (opcao == 2)
            {
                Console.Write("Digite o nome do item para remover: ");
                string item = Console.ReadLine();
                if (listaCompras.Remove(item))
                {
                    Console.WriteLine("Item removido!");
                }
                else
                {
                    Console.WriteLine("Item não encontrado.");
                }
            }
            else if (opcao == 3)
            {
                Console.WriteLine("\nItens na lista:");
                foreach (string item in listaCompras)
                {
                    Console.WriteLine($"- {item}");
                }
            }
            else if (opcao == 4)
            {
                Console.WriteLine($"\nQuantidade total de itens: {listaCompras.Count}");
            }
        }
    }
}
