using System;

[cite_start]
public class IdadeInvalidaException : Exception
{
    [cite_start]public IdadeInvalidaException(string mensagem) : base(mensagem) { } // Construtor base [cite: 65]
}

class Exercicio4
{
    [cite_start]
    static void VerificarIdade(int idade)
    {
        if (idade < 18)
        {
            [cite_start]
            throw new IdadeInvalidaException("Idade mínima para acesso é 18 anos.");
        }
        
        Console.WriteLine("Acesso permitido.");
    }

    static void Main()
    {
        try
        {
            [cite_start]Console.Write("Digite a idade: "); [cite: 94]
            int idade = int.Parse(Console.ReadLine());
            
            VerificarIdade(idade); 
        }
        [cite_start]catch (IdadeInvalidaException ex) 
        {
            [cite_start]Console.WriteLine($"Erro: {ex.Message}"); [cite: 95]
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Por favor, digite um número válido para a idade.");
        }
    }
}
