using System;

class Program
{
    static void Main()
    {
        // Vetor de números inteiros não ordenado
        int[] vetor = { 5, 2, 9, 1, 7 };

        // Ordena o vetor
        Array.Sort(vetor);

        // Exibe o vetor ordenado
        Console.WriteLine("Vetor ordenado:");
        foreach (int num in vetor)
        {
            Console.WriteLine(num);
        }
    }
}
