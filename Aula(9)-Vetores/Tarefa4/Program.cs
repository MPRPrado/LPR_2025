﻿using System;

internal class Program

{
    static void Main(string[] args)
    {
        int[,] matrizA = new int[3, 3];
        int[,] matrizB = new int[3, 3];
        int[,] matrizResultado = new int[3, 3];

        Console.WriteLine("Digite os elementos da matriz A (3x3):");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Elemento A[{i + 1}, {j + 1}]: ");
                matrizA[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Digite os elementos da matriz B (3x3):");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Elemento B[{i + 1}, {j + 1}]: ");
                matrizB[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Resultado da multiplicação das matrizes A*B:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrizResultado[i, j] = 0;
                for (int k = 0; k < 3; k++)
                {
                    matrizResultado[i, j] += matrizA[i, k] * matrizB[k, j];
                }
                Console.Write($"{matrizResultado[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}