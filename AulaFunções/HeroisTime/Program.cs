using System;
using System.ComponentModel.Design;

class Program
{
    string nomeHeroi1 = "", poderHeroi1 = "";
    int pontuacaoHeroi1 = 0;

    string nomeHeroi2 = "", poderHeroi2 = "";
    int pontuacaoHeroi2 = 0;

    string nomeHeroi3 = "", poderHeroi3 = "";
    int pontuacaoHeroi3 = 0;

    string nomeHeroi4 = "", poderHeroi4 = "";
    int pontuacaoHeroi4 = 0;

    string nomeHeroi5 = "", poderHeroi5 = "";
    int pontuacaoHeroi5 = 0;

    string equipeHeroi1 = "", equipeHeroi2 = "", equipeHeroi3 = "";
    int pontuacaoTotalEquipe = 0;




    void cadastrarHeroi()
    {
        Console.WriteLine("Cadastro de Herói:");
        int contador = 0;
        while (contador < 5)
        {
            string nome = "", poder = "";
            int pontuacao = 0;
            Console.Write("Nome do herói: ");
            nome = Console.ReadLine();
            Console.Write("Poder do herói: ");
            poder = Console.ReadLine();
            Console.Write("Pontuação do herói: ");
            pontuacao = Convert.ToInt32(Console.ReadLine());

            if (contador == 0)
            {
                nomeHeroi1 = nome;
                poderHeroi1 = poder;
                pontuacaoHeroi1 = pontuacao;
                Console.WriteLine("Quer cadastrar mais heróis? (s/n)");
                string resposta = Console.ReadLine();
                if (resposta == "s")
                {
                    contador++;
                }
                else if (resposta == "n")
                {
                    break;
                }

            }
            else if (contador == 1)
            {
                nomeHeroi2 = nome;
                poderHeroi2 = poder;
                pontuacaoHeroi2 = pontuacao;
                Console.WriteLine("Quer cadastrar mais heróis? (s/n)");
                string resposta = Console.ReadLine();
                if (resposta == "s")
                {
                    contador++;
                }
                else if (resposta == "n")
                {
                    break;
                }

            }
            else if (contador == 2)
            {
                nomeHeroi3 = nome;
                poderHeroi3 = poder;
                pontuacaoHeroi3 = pontuacao;
                Console.WriteLine("Quer cadastrar mais heróis? (s/n)");
                string resposta = Console.ReadLine();
                if (resposta == "s")
                {
                    contador++;
                }
                else if (resposta == "n")
                {
                    break;
                }
            }
            else if (contador == 3)
            {
                nomeHeroi4 = nome;
                poderHeroi4 = poder;
                pontuacaoHeroi4 = pontuacao;
                Console.WriteLine("Quer cadastrar mais heróis? (s/n)");
                string resposta = Console.ReadLine();
                if (resposta == "s")
                {
                    contador++;
                }
                else if (resposta == "n")
                {
                    break;
                }
            }
            else if (contador == 4)
            {
                nomeHeroi5 = nome;
                poderHeroi5 = poder;
                pontuacaoHeroi5 = pontuacao;
                Console.WriteLine("Quer cadastrar mais heróis? (s/n)");
                string resposta = Console.ReadLine();
                if (resposta == "s")
                {
                    contador++;
                }
                else if (resposta == "n")
                {
                    break;
                }
            }

        
        }

        
    }

    void selecionarEquipe()
    {
        Console.WriteLine("Selecione 3 heróis para formar sua equipe:");
        Console.WriteLine($"1 - {nomeHeroi1} (Poder: {poderHeroi1}, Pontuação: {pontuacaoHeroi1})");
        Console.WriteLine($"2 - {nomeHeroi2} (Poder: {poderHeroi2}, Pontuação: {pontuacaoHeroi2})");
        Console.WriteLine($"3 - {nomeHeroi3} (Poder: {poderHeroi3}, Pontuação: {pontuacaoHeroi3})");
        Console.WriteLine($"4 - {nomeHeroi4} (Poder: {poderHeroi4}, Pontuação: {pontuacaoHeroi4})");
        Console.WriteLine($"5 - {nomeHeroi5} (Poder: {poderHeroi5}, Pontuação: {pontuacaoHeroi5})");

        Console.Write("Escolha o herói 1: ");
        int escolha1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Escolha o herói 2: ");
        int escolha2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Escolha o herói 3: ");
        int escolha3 = Convert.ToInt32(Console.ReadLine());

        if (escolha1 == 1) equipeHeroi1 = nomeHeroi1;
        if (escolha1 == 2) equipeHeroi1 = nomeHeroi2;
        if (escolha1 == 3) equipeHeroi1 = nomeHeroi3;
        if (escolha1 == 4) equipeHeroi1 = nomeHeroi4;
        if (escolha1 == 5) equipeHeroi1 = nomeHeroi5;

        if (escolha2 == 1) equipeHeroi2 = nomeHeroi1;
        if (escolha2 == 2) equipeHeroi2 = nomeHeroi2;
        if (escolha2 == 3) equipeHeroi2 = nomeHeroi3;
        if (escolha2 == 4) equipeHeroi2 = nomeHeroi4;
        if (escolha2 == 5) equipeHeroi2 = nomeHeroi5;

        if (escolha3 == 1) equipeHeroi3 = nomeHeroi1;
        if (escolha3 == 2) equipeHeroi3 = nomeHeroi2;
        if (escolha3 == 3) equipeHeroi3 = nomeHeroi3;
        if (escolha3 == 4) equipeHeroi3 = nomeHeroi4;
        if (escolha3 == 5) equipeHeroi3 = nomeHeroi5;

        pontuacaoTotalEquipe = 0;
        if (escolha1 == 1) pontuacaoTotalEquipe += pontuacaoHeroi1;
        if (escolha1 == 2) pontuacaoTotalEquipe += pontuacaoHeroi2;
        if (escolha1 == 3) pontuacaoTotalEquipe += pontuacaoHeroi3;
        if (escolha1 == 4) pontuacaoTotalEquipe += pontuacaoHeroi4;
        if (escolha1 == 5) pontuacaoTotalEquipe += pontuacaoHeroi5;

        if (escolha2 == 1) pontuacaoTotalEquipe += pontuacaoHeroi1;
        if (escolha2 == 2) pontuacaoTotalEquipe += pontuacaoHeroi2;
        if (escolha2 == 3) pontuacaoTotalEquipe += pontuacaoHeroi3;
        if (escolha2 == 4) pontuacaoTotalEquipe += pontuacaoHeroi4;
        if (escolha2 == 5) pontuacaoTotalEquipe += pontuacaoHeroi5;

        if (escolha3 == 1) pontuacaoTotalEquipe += pontuacaoHeroi1;
        if (escolha3 == 2) pontuacaoTotalEquipe += pontuacaoHeroi2;
        if (escolha3 == 3) pontuacaoTotalEquipe += pontuacaoHeroi3;
        if (escolha3 == 4) pontuacaoTotalEquipe += pontuacaoHeroi4;
        if (escolha3 == 5) pontuacaoTotalEquipe += pontuacaoHeroi5;

        Console.WriteLine("Equipe selecionada com sucesso!");
    }

    void exibirEquipe()
    {
        Console.WriteLine("Equipe selecionada:");
        Console.WriteLine($"Herói 1: {equipeHeroi1}");
        Console.WriteLine($"Herói 2: {equipeHeroi2}");
        Console.WriteLine($"Herói 3: {equipeHeroi3}");
        Console.WriteLine($"Pontuação total da equipe: {pontuacaoTotalEquipe}");
    }

    void menu()
    {
        while (true)
        {
            Console.WriteLine("Menu Principal:");
            Console.WriteLine("1 - Cadastrar Herói");
            Console.WriteLine("2 - Selecionar Equipe");
            Console.WriteLine("3 - Exibir Equipe");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    cadastrarHeroi();
                    break;
                case 2:
                    selecionarEquipe();
                    break;
                case 3:
                    exibirEquipe();
                    break;
                case 4:
                    Console.WriteLine("Saindo do programa...");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
    static void Main()
    {
        Console.WriteLine("Bem-vindo ao sistema de cadastro de heróis!");
        new Program().menu();

    }
}