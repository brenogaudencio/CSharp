using System;

class Program
{
    static void Main()
    {
        int maior = 0, posicao = 0;

        for (int i = 1; i <= 100; i++)
        {
            int n = int.Parse(Console.ReadLine());
            if (n > maior)
            {
                maior = n;
                posicao = i;
            }
        }

        Console.WriteLine(maior);
        Console.WriteLine(posicao);
    }
}
