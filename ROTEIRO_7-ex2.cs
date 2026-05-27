using System;
using System.Collections.Generic;

class Exercicio2
{
    static void Main()
    {
        Dictionary<int, string> catalogo = new Dictionary<int, string>();
        
        Console.Write("Digite o código do produto para adicionar: ");
        int codigo = int.Parse(Console.ReadLine());
        
        if (catalogo.ContainsKey(codigo))
        {
            Console.WriteLine("Erro: Este código já existe no catálogo.");
        }
        else
        {
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            catalogo.Add(codigo, nome);
            Console.WriteLine("Produto cadastrado com sucesso!");
        }

        catalogo.Add(200, "Teclado");

        Console.Write("\nDigite o código do produto que deseja buscar: ");
        int busca = int.Parse(Console.ReadLine());
        
        if (catalogo.ContainsKey(busca))
        {
            Console.WriteLine($"Produto encontrado: {catalogo[busca]}");
        }
        else
        {
            Console.WriteLine("Produto não encontrado.");
        }

        Console.WriteLine("\nCatálogo completo:");
        foreach (KeyValuePair<int, string> produto in catalogo)
        {
            Console.WriteLine($"Código: {produto.Key} | Nome: {produto.Value}");
        }
    }
}
