using System;

namespace Funcionario.Funcionarios
{
    internal class Funcionarios
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public Funcionarios(string nome, double salarioBruto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = CalcularImposto();
        }

        private double CalcularImposto()
        {
            if (SalarioBruto <= 2000)
                return SalarioBruto * 0.10;
            else if (SalarioBruto <= 3000)
                return SalarioBruto * 0.15;
            else
                return SalarioBruto * 0.20;
        }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Salário Líquido: R$ {SalarioLiquido():F2}");
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * (porcentagem / 100);
            Imposto = CalcularImposto();
        }
    }
}