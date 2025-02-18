using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool teste1 = 3 > 3 && 4 != 5;
            bool teste2 = 3 > 3 || 4 != 5;
            bool teste3 = !(2 > 3) && 4 != 5;
            Console.WriteLine(teste1);
            Console.WriteLine(teste2);
            Console.WriteLine(teste3);
        }
    }
}