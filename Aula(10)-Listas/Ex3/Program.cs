using System;
using System.Collections.Generic;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> nomes = new();
            Console.WriteLine("Quantos nomes deseja inserir?");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine("Digite o nome:");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite a idade:");
                int idade = int.Parse(Console.ReadLine());
                nomes.Add(nome, idade);
            }

            int somaIdades = 0;
            foreach (var item in nomes)
            {
                somaIdades += item.Value;
            }

            double mediaIdade = (double)somaIdades / nomes.Count;

            Console.WriteLine("Os nomes das pessoas acima da média são:");
            foreach (var item in nomes)
            {
                if (item.Value > mediaIdade)
                {
                    Console.WriteLine($"{item.Key} com {item.Value} anos");
                }
            }
        }
    }
}