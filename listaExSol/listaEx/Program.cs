using System;

class Program
{
    static void Main()
    {

        Random rand = new Random();

        int randomNumber = rand.Next(0, 101);

        // Tamanho da array
        int tamanhoArray = 100;

        // Array para armazenar os números aleatórios
        int[] numerosAleatorios = new int[tamanhoArray];

        // Preenche a array com números aleatórios
        for (int i = 0; i < tamanhoArray; i++)
        {
            numerosAleatorios[i] = rand.Next(100, 501);
        }


        // Ordena o vetor
        Array.Sort(numerosAleatorios);

        // Exibe o vetor ordenado
        Console.WriteLine("Vetor ordenado:");
        foreach (int num in numerosAleatorios)
        {
            Console.WriteLine(num);
        }
    }
}
