using System.ComponentModel.Design;

public struct Heroi
{
    public string Nome;
    public int Pontuação;
    public string Poder;
    public int quantidade;
}
class Program
{
    static Heroi[] herois = new Heroi[5];
    void cadastrarHerois()
    {
        Console.WriteLine("Quantos herois voce quer cadastrar?");
        int quantidade = int.Parse(Console.ReadLine());
        if (quantidade < 3 || quantidade > 5)
        {
            Console.WriteLine("Quantidade minima de herois e 3 e a maxima e 5.");
            return;
        }
        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Digite o nome do heroi {i + 1}:");
            herois[i].Nome = Console.ReadLine();
            Console.WriteLine($"Digite a pontuacao do heroi {i + 1}:");
            herois[i].Pontuação = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o poder do heroi {i + 1}:");
            herois[i].Poder = Console.ReadLine();
        }      
    }
    void selecionarEquipe(){
        Console.WriteLine("Selecione os herois que deseja na equipe:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Selecione o heroi {i + 1}:");
            switch (i)
            {
                case 0:
                    exibirEquipe();
                    Console.WriteLine("1 - " + herois[0].Nome);
                    break;
                case 1:
                    exibirEquipe();
                    Console.WriteLine("2 - " + herois[1].Nome);
                    break;
                case 2:
                    exibirEquipe();
                    Console.WriteLine("3 - " + herois[2].Nome);
                    break;
                default:
                    Console.WriteLine("Selecao invalida.");
                    break;
            }




        }
           
    }
    void exibirEquipe()
    {
        Console.WriteLine("Equipe selecionada:");
        foreach (Heroi heroi in herois)
        {
            if (!string.IsNullOrEmpty(heroi.Nome))
            {
                Console.WriteLine($"Nome: {heroi.Nome}, Pontuação: {heroi.Pontuação}, Poder: {heroi.Poder}");
            }
        }
    }
    void menu()
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Cadastrar herois");
            Console.WriteLine("2 - Selecionar equipe");
            Console.WriteLine("3 - Exibir equipe");
            Console.WriteLine("4 - Sair");
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
                    exibirEquipe();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opcao invalida.");
                    break;
            }
        }
    }
    void pontuacaoTotal()
    {
        int total = 0;
        foreach (Heroi heroi in herois)
        {
            total += heroi.Pontuação;
        }
        Console.WriteLine($"Pontuação total da equipe: {total}");
    }

    static void Main(string[] args)
    {
            Console.WriteLine("Bem-vindo ao sistema de cadastro de heróis!");
            new Program().menu();

        

    }
}
