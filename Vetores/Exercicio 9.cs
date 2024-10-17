using array;
using System;

public class Ex9
{

    static void Main()
    {
        Console.WriteLine("digite a quantidades de numeros que tem o array");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        BibliotecaArray.geraVetor(array);
        BibliotecaArray.mostraVetor(array);

        Console.WriteLine("\n Digite um valor para verificar quantas vezes aparece");
        int valor = int.Parse(Console.ReadLine());

        int cont = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == valor)
            {
                cont++;
            }
        }
        Console.WriteLine($"O valor {valor} aparece {cont}");
    }
}


