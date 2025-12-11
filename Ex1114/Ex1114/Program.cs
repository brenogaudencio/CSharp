using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senha;
            senha = int.Parse(Console.ReadLine());

            while (senha != 2002) {
                Console.WriteLine("Senha inválida!");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido!");
        }
    }
}