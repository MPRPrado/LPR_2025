using System;
using Alunos;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a matrícula do aluno: ");
            string matricula = Console.ReadLine();
            
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();
            
            Console.Write("Digite a nota da primeira prova: ");
            double prova1 = double.Parse(Console.ReadLine());
            
            Console.Write("Digite a nota da segunda prova: ");
            double prova2 = double.Parse(Console.ReadLine());
            
            Console.Write("Digite a nota do trabalho: ");
            double trabalho = double.Parse(Console.ReadLine());
            
            Aluno aluno = new Aluno(matricula, nome, prova1, prova2, trabalho);
            
            Console.WriteLine($"\nAluno: {aluno.Nome}");
            Console.WriteLine($"Matrícula: {aluno.Matricula}");
            Console.WriteLine($"Média: {aluno.Media():F2}");
            
            double notaFinal = aluno.Final();
            if (notaFinal == 0)
                Console.WriteLine("Aluno aprovado!");
            else
                Console.WriteLine($"Precisa tirar {notaFinal:F2} na prova final");
        }
    }
}