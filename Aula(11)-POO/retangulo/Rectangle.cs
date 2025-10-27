using System;
using System.Runtime.CompilerServices;

public class Rectangle
{
    public double Altura { get; set; }
    public double Largura { get; set; }

    public double Area()
    {
        return Altura * Largura;
    }
    public double Perimetro()
    {
        return 2 * (Altura + Largura);
    }

}
