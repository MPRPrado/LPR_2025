﻿using System;

public struct Heroi
{
    public string Nome;
    public int Pontuação;
    public string Poder;
}

class Program
{
    static Heroi[] herois = new Heroi[5];
    static Heroi[] equipe = new Heroi[3];
    static int pontuacaoTotalEquipe = 0;
    
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao sistema de cadastro de heróis!");
        menu();
    }
    
    static void menu()
    {
        while (true)
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1 - Cadastrar heróis");
            Console.WriteLine("2 - Selecionar equipe");
            Console.WriteLine("3 - Exibir equipe selecionada");
            Console.WriteLine("4 - Pontuação da equipe");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha uma opção: ");
            
            int opcao = int.Parse(Console.ReadLine());
            
            switch (opcao)
            {
                case 1:
                    cadastrarHerois();
                    break;
                case 2:
                    selecionarEquipe();
                    break;
                case 3:
                    exibirEquipeSelecionada();
                    break;
                case 4:
                    int pontuacao = calcularPontuacaoTotal();
                    Console.WriteLine($"Pontuação total da equipe: {pontuacao}");
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
    
    static void cadastrarHerois()
    {
        Console.WriteLine("\n=== CADASTRO DE HERÓIS ===");
        Console.WriteLine("Digite 0 para voltar ao menu ou qualquer outro número para continuar:");
        int opcao = int.Parse(Console.ReadLine());
        
        if (opcao == 0)
        {
            return;
        }
        
        Console.WriteLine("Cadastre até 5 heróis:");
        
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"\nCadastro do herói #{i + 1}:");
            Console.Write("Digite o nome do herói: ");
            herois[i].Nome = Console.ReadLine();
            Console.Write("Digite a pontuação do herói: ");
            herois[i].Pontuação = int.Parse(Console.ReadLine());
            Console.Write("Digite o poder do herói: ");
            herois[i].Poder = Console.ReadLine();
        }
        
        Console.WriteLine("Heróis cadastrados com sucesso!");
    }
    
    static void selecionarEquipe()
    {
        Console.WriteLine("\n=== SELEÇÃO DE EQUIPE ===");
        Console.WriteLine("Digite 0 para voltar ao menu ou qualquer outro número para continuar:");
        int opcao = int.Parse(Console.ReadLine());
        
        if (opcao == 0)
        {
            return;
        }
        
        Console.WriteLine("Escolha 3 heróis para sua equipe:");
        
        // Exibir heróis cadastrados
        for (int i = 0; i < 5; i++)
        {
            if (!string.IsNullOrEmpty(herois[i].Nome))
            {
                Console.WriteLine($"{i + 1} - Nome: {herois[i].Nome}, Pontuação: {herois[i].Pontuação}, Poder: {herois[i].Poder}");
            }
        }
        
        // Selecionar 3 heróis
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Escolha o herói {i + 1} (digite o número): ");
            int escolha = int.Parse(Console.ReadLine());
            
            if (escolha >= 1 && escolha <= 5)
            {
                equipe[i] = herois[escolha - 1];
                Console.WriteLine($"Herói {equipe[i].Nome} adicionado à equipe!");
            }
            else
            {
                Console.WriteLine("Escolha inválida. Tente novamente.");
                i--; // Repetir esta escolha
            }
        }
    }
    
    static void exibirEquipeSelecionada()
    {
        Console.WriteLine("\n=== EQUIPE SELECIONADA ===");
        Console.WriteLine("Digite 0 para voltar ao menu ou qualquer outro número para continuar:");
        int opcao = int.Parse(Console.ReadLine());
        
        if (opcao == 0)
        {
            return;
        }
        
        bool temEquipe = false;
        
        for (int i = 0; i < 3; i++)
        {
            if (!string.IsNullOrEmpty(equipe[i].Nome))
            {
                Console.WriteLine($"\nHerói {i + 1}:");
                Console.WriteLine($"Nome: {equipe[i].Nome}");
                Console.WriteLine($"Poder: {equipe[i].Poder}");
                Console.WriteLine($"Pontuação: {equipe[i].Pontuação}");
                temEquipe = true;
            }
        }
        
        if (!temEquipe)
        {
            Console.WriteLine("Nenhum herói foi selecionado para a equipe ainda.");
        }
    }
    
    static int calcularPontuacaoTotal()
    {
        int total = 0;
        
        for (int i = 0; i < 3; i++)
        {
            if (!string.IsNullOrEmpty(equipe[i].Nome))
            {
                total += equipe[i].Pontuação;
            }
        }
        
        return total;
    }
}
