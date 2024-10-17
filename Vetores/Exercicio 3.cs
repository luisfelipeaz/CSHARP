using System;

public class ex3
{
    public static void Main()
    {
        int n;
        Console.WriteLine("Tamanho do vetor");
        n = int.Parse(Console.ReadLine());

        double[] vetor = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elemento {i + 1}:");
            vetor[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("o menor elemento e:" + Menorvalor(vetor));
    }

    static double Menorvalor(double[] vetor)
    {
        double menor = vetor[0];
        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] < menor)
                menor = vetor[i];
        }
        return menor;
    }
}
