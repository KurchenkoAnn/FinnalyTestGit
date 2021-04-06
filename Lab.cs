using System;

public class Program
{
    static void CreateMas2(float[,] M, int m, int n)
    {
        Random r = new Random();
        // float[,] M = new float[4, 5]; // выделить память для массива

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                M[i, j] = r.Next(10);
            }
        }
    }
    static void ReadMas2(float[,] M2, int m, int n)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("{0}\t", M2[i, j]);
            }
            Console.WriteLine();
        }
    }
    static void CreateSumMas(float[,] M2, float[] M, int m, int n)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                M[i] += M2[i, j];
            }
            Console.WriteLine();
        }
    }
    static void ReadSumMas(float[] M, int m)
    {

        for (int i = 0; i < m; i++)
        {
            Console.WriteLine("Result of column\n {0}\t", M[i]);

            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        int m = 4, n = 5;
        float[,] M = new float[4, 5];
        float[] MSum = new float[4];
        CreateMas2(M, 4, 5);
        ReadMas2(M, 4, 5);
        CreateSumMas(M, MSum, m, n);
        ReadSumMas(MSum, m);
        Console.ReadLine();
    }

}
