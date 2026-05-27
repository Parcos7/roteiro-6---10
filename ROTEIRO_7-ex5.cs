using System;
using System.Collections.Generic;

class Exercicio5
{
    static void Main()
    {
        Stack<char> pilhaLetras = new Stack<char>();

        Console.Write("Digite uma palavra para ser invertida: ");
        string palavra = Console.ReadLine();

        foreach (char letra in palavra)
        {
            pilhaLetras.Push(letra);
        }

        Console.Write("Palavra invertida: ");
        while (pilhaLetras.Count > 0)
        {
            Console.Write(pilhaLetras.Pop());
        }
        Console.WriteLine(); 
    }
}
