using System;

internal class Program

{
    static void Main(string[] args)
    {
        int[] inteiros = new int[10];

        Console.WriteLine("Digite 10 números inteiros:");
        for (int i = 0; i < inteiros.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            inteiros[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Digite um número para pesquisar: ");
        int numeroPesquisa = Convert.ToInt32(Console.ReadLine());
        int contadorOcorrencias = 0;
        Console.WriteLine("O número aparece nas seguintes posições:");
        for (int i = 0; i < inteiros.Length; i++)
        {
            if (inteiros[i] == numeroPesquisa)
            {
                Console.WriteLine($"Posição {i + 1}");
                contadorOcorrencias++;
            }
        }
        if (contadorOcorrencias > 0)
        {
            Console.WriteLine($"O número {numeroPesquisa} foi encontrado {contadorOcorrencias} vezes.");
        
        }
        else
        {
            Console.WriteLine($"O número {numeroPesquisa} não foi encontrado no vetor.");
        
        }

    }
}