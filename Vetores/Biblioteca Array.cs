using System;

namespace array
{
    public class BibliotecaArray
    {
        public static void leiaVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"[{i}]:");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void geraVetor(int[] vetor)
        {
            Random random = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(1, 100);
            }
        }
        public static void mostraVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"|{vetor[i]}");
            }
        }
        public static int somaVetor(int[] vetor)
        {
            int soma = 0;
            for (int i = 0; i < vetor.Length; i++)

                soma += vetor[i];

            return soma;
        }
        public static int ContaImpares(int[] vetor)
        {
            int cont = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 != 0)
                {
                    cont++;
                }
            }
            return cont;
        }

        public static double Menorvalor(double[] vetor)
        {
            double menor = vetor[0];
            for (int i = 1; i < vetor.Length; i++)
            {
                if (vetor[i] < menor)
                    menor = vetor[i];
            }
            return menor;
        }

        public static double Maiorvalor(double[] vetor)
        {
            double maior = vetor[0];
            for (int i = 1; i < vetor.Length; i++)
            {
                if (vetor[i] > maior)
                    maior = vetor[i];
            }
            return maior;
        }

        public static void InverterVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length / 2; i++)
            {

                int temp = vetor[i];
                vetor[i] = vetor[vetor.Length - 1 - i];
                vetor[vetor.Length - 1 - i] = temp;
            }


        }

    }
}