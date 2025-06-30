using System;
using System.Collections.Generic;
class Program
{
    static int ehmaior(string a, string b)
    {
        if (a.Length > b.Length) return 1;
        if (a.Length < b.Length) return -1;

        return 0;
    }
    static void Main(string[] args)
    {
        List<string> nomes = new();
        Console.WriteLine("Quantos nomes deseja inserir?");
        int quantidade = int.Parse(Console.ReadLine());
        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine("Digite o nome:");
            string nome = Console.ReadLine();
            Console.WriteLine($"Nome {i + 1}: {nome}");
            nomes.Add(nome);
        }
        nomes.Sort(ehmaior);
        Console.WriteLine("Nomes ordenados por tamanho:");
        foreach (var nome in nomes)
        {
            Console.WriteLine(nome);
        }

    }
}