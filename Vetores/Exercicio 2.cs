using System;

public class ex2
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
        Console.WriteLine("o maior elemento e:" + Maiorvalor(vetor));
    }

    static double Maiorvalor(double[] vetor)
    {
        double maior = vetor[0];
        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] > maior)
                maior = vetor[i];
        }
        return maior;
    }
}
