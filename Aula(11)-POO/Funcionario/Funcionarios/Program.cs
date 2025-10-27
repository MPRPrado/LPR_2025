using System;
using Funcionario.Funcionarios;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do funcionário: ");
            string nome = Console.ReadLine();
            
            Console.Write("Digite o salário bruto: R$ ");
            double salarioBruto = double.Parse(Console.ReadLine());
            
            Funcionarios funcionario = new Funcionarios(nome, salarioBruto);
            
            Console.WriteLine("\n--- Dados do Funcionário ---");
            funcionario.MostrarDados();
            
            Console.Write("\nDigite a porcentagem de aumento: ");
            double porcentagem = double.Parse(Console.ReadLine());
            
            funcionario.AumentarSalario(porcentagem);
            
            Console.WriteLine("\n--- Dados Após Aumento ---");
            funcionario.MostrarDados();
        }
    }
}