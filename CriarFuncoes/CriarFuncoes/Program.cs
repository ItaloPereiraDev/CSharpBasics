using System;

namespace MyApp
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);
            Console.WriteLine($"Maior número digitado:{resultado}");
        }
        static int Maior(int x, int y, int z)
        {
            int big = x;

            if (y > big)
            {
                big = y;
            }
            if (z > big)
            {
                big = z;
            }
            return big;
        }

    }
}