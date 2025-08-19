using System;
using System.Runtime.InteropServices.Marshalling;

internal class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Escolha a classe (1)Guerreira, (2)Mago ou (3)Arqueira:");
        int x = Convert.ToInt32 (Console.ReadLine());
        switch (x)
        {
            case 1:
                Console.WriteLine("Guerreiro:Ataque Pesado ou Defesa Total");
                break;
            case 2:
                Console.WriteLine("Mago: Bola de Fogo ou Escudo de Gelo");
                break;
            case 3:
                Console.WriteLine("Arqueira: Flecha Precisa ou Disparo Triplo");
                break;
            default:
                Console.WriteLine("Escolha um Personagem");
                break;
        }


    }
}