using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null");
            }
            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }

            double a = x ?? 5;
            double b = y ?? 5;
            Console.WriteLine(a); // 5, pq x é nulo
            Console.WriteLine(b);// 10, pq recebe y, que não é nulo
        }
    }
}