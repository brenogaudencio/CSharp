using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, x = 0, y = 0, z = 0;
            double porcentagem, valorTotalCompra, valorTotalVenda, lucroTotal;
            string[] produto;
            double[] precoCcompra, precoVenda;
            valorTotalCompra = 0.0;
            valorTotalVenda = 0.0;
            lucroTotal = 0.0;   

            N = int.Parse(Console.ReadLine());
            produto = new string[N];
            precoCcompra = new double[N];
            precoVenda = new double[N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                produto[i] = s[0];
                precoCcompra[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                precoVenda[i] = double.Parse(s[2], CultureInfo.InvariantCulture);

                porcentagem = ((precoVenda[i] - precoCcompra[i]) * 100.0 / precoCcompra[i]);

                if (porcentagem < 10.0)
                {
                    x++;
                }
                else if (porcentagem >= 10.0 && porcentagem <= 20.0)
                {
                    y++;
                } else if (porcentagem > 20.0) {
                    z++;
                }

                valorTotalCompra += precoCcompra[i];
                valorTotalVenda += precoVenda[i];
                lucroTotal += precoVenda[i] - precoCcompra[i];
            }
            Console.WriteLine("Lucro abaixo de 10%: " + x);
            Console.WriteLine("Lucro entre 10% e 20%: " + y);
            Console.WriteLine("Lucro acima de 20%: " + z);
            Console.WriteLine("Valor total de compra: " + valorTotalCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + valorTotalVenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + lucroTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}