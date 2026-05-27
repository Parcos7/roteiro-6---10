using System;

class Exercicio3
{
    static void Main()
    {
        [cite_start]
        try
        {
            Console.Write("Digite um número inteiro: ");
            string entrada = Console.ReadLine();
            
            [cite_start]
            int numero = int.Parse(entrada); 
            
            [cite_start]Console.WriteLine($"Você digitou o número: {numero}"); [cite: 83]
        }
        catch (FormatException)
        {
            [cite_start]
            Console.WriteLine("Valor inválido. Por favor, digite um número inteiro."); 
        }
    }
}
