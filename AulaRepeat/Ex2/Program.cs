using System;  

internal class Program  
{
static int numAleatorio = new Random().Next(1, 100);
static int chute = 0;
static int tentativas = 0;
    static void Main(string[] args)
    {
        do {
            Console.WriteLine("Digite um número entre 1 e 100");
            chute = int.Parse(Console.ReadLine());
            tentativas++;
            if (chute > numAleatorio) {
                Console.WriteLine("O número é menor que o chute");
            } else {
                Console.WriteLine("O número é maior que o chute");
            }


        } while (chute != numAleatorio);
                Console.WriteLine("Parabéns, você acertou!");
                Console.WriteLine($"Número de tentativas: {tentativas}");
         
    
}
}

