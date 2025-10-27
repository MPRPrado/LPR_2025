using System;

internal class Program
{
    private static void Main(string[] args)
    {
       Rectangle rect = new Rectangle();

        Console.Write("Digite a altura do retângulo: ");
        rect.Altura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a largura do retângulo: ");
        rect.Largura = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Área: {rect.Area()}");
        Console.WriteLine($"Perímetro: {rect.Perimetro()}");

    }
}
