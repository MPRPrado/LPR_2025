using System;  

internal class Program  
{
   
    static void Main(string[] args)
    {
        float hora , salario, horav;
        uint fun;
        Console.WriteLine("Digite seu numero");
        fun = uint.Parse(Console.ReadLine());
        Console.WriteLine("Digite as horas trabalhadas");
        hora = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor da hora");

        horav = float.Parse(Console.ReadLine());


        if(hora >= 0 && horav >= 0){

        
        salario = hora * horav;   
        Console.WriteLine($"O salario do funcionario {fun} e: R${salario:F2}");
   
        
        }else{
            Console.WriteLine("Numero invalido");
        }
    }
}
