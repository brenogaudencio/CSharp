using System;
using System.Globalization;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomeM = Console.ReadLine().Split(' ');
            string nome = nomeM[0];
            int idade = int.Parse(nomeM[1]);

            string[] NomeJ = Console.ReadLine().Split(' ');
            string nome2 = NomeJ[0];
            int idade2 = int.Parse(NomeJ[1]);

            double idadeMedia = (idade + idade2) / 2.0;

            Console.WriteLine("A idade média de " + nome + " e " + nome2 + " é de " + idadeMedia.ToString(CultureInfo.InvariantCulture) + " anos.");
        }
    }
}   