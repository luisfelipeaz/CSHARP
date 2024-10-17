using System;
using array;

public class Ex1
{
    static void Main()
    {
        int n;
        Console.WriteLine("Tamanho do vetor");
        n = int.Parse(Console.ReadLine());

        int[] vetor = new int[n];

        BibliotecaArray.geraVetor(vetor);
        Console.WriteLine("Vetor gerado");

        BibliotecaArray.mostraVetor(vetor);

        int soma = BibliotecaArray.somaVetor(vetor);
        Console.WriteLine($"A soma e {soma}");

        Console.ReadKey();
    }

}