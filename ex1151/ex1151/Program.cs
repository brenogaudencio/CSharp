using System;

class URI
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int a = 0, b = 1;

        for (int i = 0; i < N; i++)
        {
            if (i == 0)
                Console.Write(a);
            else if (i == 1)
                Console.Write(" " + b);
            else
            {
                int next = a + b;
                Console.Write(" " + next);
                a = b;
                b = next;
            }
        }
        Console.WriteLine();
    }
}
