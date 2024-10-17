using array;
using System;

class Ex8
{

    static void Main()
    {
        Console.WriteLine("digite a quantidades de numeros que tem o array");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        BibliotecaArray.geraVetor(array);

        BibliotecaArray.mostraVetor(array);

        int quant = array.Length;
        Console.WriteLine($"{quant}");

        Console.WriteLine("invertendo vetor...");
        BibliotecaArray.InverterVetor(array);

        BibliotecaArray.mostraVetor(array);

    }

}
