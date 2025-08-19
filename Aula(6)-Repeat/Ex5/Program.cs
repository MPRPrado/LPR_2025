using System;


static void Main()
{
    double horas;
    int dias = 5;
    double HorasNecessarias = 1000;
    double horasAcumuladas = 0;
    int semanasContadas = 0;
    do
    {
        Console.Write("Digite o número de horas de treinamento por dia: ");
        horasPorDia = double.Parse(Console.ReadLine());
    } while (horas <= 0 || horas > 24);

    double horasPorSemana = horas * dias;

    while (horasAcumuladas < HorasNecessarias)
    {
        horasAcumuladas += horasPorSemana;
        semanasContadas++;
    }

    double diasNecessarios = semanasContadas * dias;
    double mesesNecessarios = semanasContadas / 4.5;

    Console.WriteLine($"Total de horas de treinamento por semana: {horasPorSemana} horas");
    Console.WriteLine($"Dias necessários para alcançar 1000 horas: {diasNecessarios} dias");
    Console.WriteLine($"Semanas necessárias: {semanasContadas} semanas");
    Console.WriteLine($"Meses necessários: {mesesNecessarios} meses");

}
