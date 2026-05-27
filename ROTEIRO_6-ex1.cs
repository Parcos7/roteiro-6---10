using System;

class Exercicio1
{
    static void Main()
    {
        try
        {
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            
            [cite_start]
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("O nome do produto não pode estar em branco.");
            }

            Console.Write("Digite o preço do produto: ");
            float preco = float.Parse(Console.ReadLine());

            [cite_start]
            if (preco <= 0)
            {
                throw new ArgumentException("O preço deve ser maior que zero.");
            }

            Console.WriteLine("Produto cadastrado com sucesso!");
        }
        [cite_start]catch (ArgumentException ex) 
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: O preço digitado é inválido.");
        }
    }
}
