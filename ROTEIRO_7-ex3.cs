using System;
using System.Collections.Generic;

class Exercicio3
{
    static void Main()
    {
        HashSet<int> numerosUnicos = new HashSet<int>();
        int numero;

        Console.WriteLine("Digite números inteiros (digite 0 para parar):");

        while (true)
        {
            Console.Write("Número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero == 0)
            {
                break; 
            }

            numerosUnicos.Add(numero); 
        }

        Console.WriteLine("\nNúmeros únicos digitados:");
        foreach (int num in numerosUnicos)
        {
            Console.WriteLine($"- {num}");
        }
    }
}
