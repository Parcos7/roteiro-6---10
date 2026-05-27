using System;

class Exercicio2
{
    [cite_start]
    static float ConverterParaCelsius(string entrada)
    {
        [cite_start]
        return float.Parse(entrada);
    }

    static void Main()
    {
        [cite_start]while (true)
        {
            try
            {
                Console.Write("Digite a temperatura em Celsius: ");
                string entrada = Console.ReadLine();
                
                float temperatura = ConverterParaCelsius(entrada);
                
                Console.WriteLine($"Temperatura aceita: {temperatura}°C");
                break; 
            }
            [cite_start]catch (FormatException) 
            {
                Console.WriteLine("Formato inválido! Por favor, digite um número válido.");
            }
        }
    }
}
