using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s = 0.0; 
                
            int b = 1;

            for (int i = 1; i <= 39; i+=2) {
                s += (double)i / b;
                b *= 2;
            }
            Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}