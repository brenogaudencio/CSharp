using System;

class Program
{
    static void Main()
    {
        // Loop para os valores de I (1, 3, 5, 7, 9)
        for (int i = 1; i <= 9; i += 2)
        {
            // Loop para os valores de J (7, 6, 5)
            for (int j = 7; j >= 5; j--)
            {
                Console.WriteLine($"I={i} J={j}");
            }
        }
    }
}
