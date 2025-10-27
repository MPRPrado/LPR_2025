using System;

namespace Alunos
{
    internal class Aluno
    {
        public string Matricula;
        public string Nome;
        public double Prova1;
        public double Prova2;
        public double Trabalho;

        public Aluno(string matricula, string nome, double prova1, double prova2, double trabalho)
        {
            Matricula = matricula;
            Nome = nome;
            Prova1 = prova1;
            Prova2 = prova2;
            Trabalho = trabalho;
        }

        public double Media()
        {
            return (Prova1 * 2.5 + Prova2 * 2.5 + Trabalho * 2) / 7;
        }

        public double Final()
        {
            double media = Media();
            if (media >= 6.0)
                return 0;
            else
                return (12.0 - media) / 2;
        }
    }
}