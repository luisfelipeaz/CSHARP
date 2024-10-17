using System;
using array;
public class ex4
{
    static void Main()
    {
        int n;
        Console.WriteLine("Tamanho do vetor");
        n = int.Parse(Console.ReadLine());

        int[] vetor = new int[n];

        BibliotecaArray.geraVetor(vetor);
        Console.WriteLine("vetor gerado");
        BibliotecaArray.mostraVetor(vetor);
        Console.WriteLine($"|{vetor})");

        int quantidadeImpares = BibliotecaArray.ContaImpares(vetor);
        Console.WriteLine($"Quantidade de valores ímpares no vetor: {quantidadeImpares}");
    }
   
}
