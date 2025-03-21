using System;  

internal class Program  
{
   
    static void Main(string[] args)
    {
        double valorf;
        float valorp1, valorp2;
        uint codep1, codep2,nump1,nump2;

        Console.WriteLine("Digite o codigo de peca 1");
        codep1 = uint.Parse(Console.ReadLine());
        Console.WriteLine("Digite o codigo de peca 2");
        codep2 = uint.Parse(Console.ReadLine());

        Console.WriteLine("Digite o quantas pecas 1");
        nump1 = uint.Parse(Console.ReadLine());
        Console.WriteLine("Digite o quantas pecas 2");
        nump2 = uint.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor da peca  1");
        valorp1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor da peca  2");
        valorp2 = float.Parse(Console.ReadLine());


        if(nump1 > 0 && nump2 > 0 && valorp2 > 0 && valorp1 >0 ){
        valorf = (nump1 * valorp1) + (nump2 * valorp2);
  
   
        Console.WriteLine($"O valor a pagar e: R${valorf:F2}");
        
        }else{
            Console.WriteLine("Numero invalido");
        }
    }
}
