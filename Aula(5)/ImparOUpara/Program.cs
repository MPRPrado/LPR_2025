// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.InteropServices.Marshalling;

internal class Program
{

    static void Main(string[] args)
    {

        int num;
        Console.WriteLine("Digite o número:");
        num = int.Parse(Console.ReadLine());
        if (num % 2 == 0)
        {

            Console.WriteLine("O numero é par");

        }
        else
        {
            Console.WriteLine("EH impar");
        }





    }

}
