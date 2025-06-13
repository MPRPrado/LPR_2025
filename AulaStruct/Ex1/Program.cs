using System.Security.Cryptography.X509Certificates;

public struct Produto
{
    public string Nome;
    public int codigo;
    public float preco;
    public float quantidade;
}

class Program
{
    static void Main(string[] args)
    {
        Produto[] vetorProduto = new Produto[3];
        Console.WriteLine("Insira os dados dos produtos");
        for (int i = 1; i < 4; i++)
        {
            Console.WriteLine($"Insira o nome do Produto{i}");
            vetorProduto[i - 1].Nome = Console.ReadLine();
            Console.WriteLine($"Insira o codigo do Produto{i}");
            vetorProduto[i - 1].codigo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Insira o preco do Produto{i}");
            vetorProduto[i - 1].preco = float.Parse(Console.ReadLine());
            Console.WriteLine($"Insira a quantidade do Produto{i}");
            vetorProduto[i - 1].quantidade = float.Parse(Console.ReadLine());
        }
        float total = 0;
        foreach (Produto produto in vetorProduto)
        {
            total = produto.quantidade * produto.preco;
        }
        Console.WriteLine($"Valor total em estoque: {total}");
    }
}
