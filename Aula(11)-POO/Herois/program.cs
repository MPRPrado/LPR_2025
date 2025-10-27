using System;
using System.Collections.Generic;

namespace Herois
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CRIADOR DE HERÓI ===");
            
            // Criar personagem
            Console.Write("Nome do herói: ");
            string nome = Console.ReadLine() ?? "Herói";
            
            Heroi heroi = new Heroi(nome, 100, 50, 15);
            
            // Selecionar arma
            List<Arma> armas = new List<Arma>
            {
                new Arma("Espada", 20, "Lâmina"),
                new Arma("Machado", 25, "Pesada"),
                new Arma("Arco", 15, "Distância"),
                new Arma("Cajado", 18, "Mágica")
            };
            
            Console.WriteLine("\nEscolha sua arma:");
            for (int i = 0; i < armas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {armas[i].Nome} (Dano: {armas[i].Dano})");
            }
            
            Console.Write("Opção: ");
            if (int.TryParse(Console.ReadLine(), out int opcao) && opcao >= 1 && opcao <= armas.Count)
            {
                heroi.ArmaEquipada = armas[opcao - 1];
            }
            else
            {
                heroi.ArmaEquipada = armas[0];
            }
            
            // Selecionar local
            Console.WriteLine("\nEscolha o local da aventura:");
            Console.WriteLine("1. Floresta ");
            Console.WriteLine("2. Montanha ");
            Console.WriteLine("3. Caverna ");
            Console.WriteLine("4. Pântano ");
            
            Console.Write("Local: ");
            Inimigo inimigo;
            
            if (int.TryParse(Console.ReadLine(), out int local))
            {
                switch (local)
                {
                    case 1:
                        inimigo = new Inimigo("Goblin", 60, 15, "Floresta");
                        break;
                    case 2:
                        inimigo = new Inimigo("Dragão", 120, 25, "Montanha");
                        break;
                    case 3:
                        inimigo = new Inimigo("Orc", 80, 18, "Caverna");
                        break;
                    case 4:
                        inimigo = new Inimigo("Troll", 100, 22, "Pântano");
                        break;
                    default:
                        inimigo = new Inimigo("Goblin", 60, 15, "Floresta");
                        break;
                }
            }
            else
            {
                inimigo = new Inimigo("Goblin", 60, 15, "Floresta");
            }
            
            Console.WriteLine($"\n=== BATALHA NA {inimigo.Tipo.ToUpper()} ===");
            Console.WriteLine($"{heroi.Nome} com {heroi.ArmaEquipada.Nome} vs {inimigo.Nome}");
            Console.WriteLine();
            
            // Batalha
            while (heroi.EstaVivo() && inimigo.EstaVivo())
            {
                int danoHeroi = heroi.Atacar();
                inimigo.ReceberDano(danoHeroi);
                Console.WriteLine($"{heroi.Nome} ataca causando {danoHeroi} de dano!");
                Console.WriteLine($"{inimigo.Nome}: {inimigo.Vida} HP");
                
                if (!inimigo.EstaVivo())
                {
                    Console.WriteLine($"\n{inimigo.Nome} foi derrotado! Vitória!");
                    break;
                }
                
                int danoInimigo = inimigo.Atacar();
                heroi.ReceberDano(danoInimigo);
                Console.WriteLine($"{inimigo.Nome} ataca causando {danoInimigo} de dano!");
                Console.WriteLine($"{heroi.Nome}: {heroi.Vida} HP\n");
                
                if (!heroi.EstaVivo())
                {
                    Console.WriteLine($"{heroi.Nome} foi derrotado! Derrota!");
                    break;
                }
            }
            
            Console.WriteLine("\nPressione Enter para sair...");
            Console.ReadLine();
        }
    }
}