using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números vc vai digitar?");
            int numeros = int.Parse(Console.ReadLine());
            double soma = 0;
            for (int i = 1; i <= numeros; i++)
            {
                Console.WriteLine($"Digite o {i}º número:");
                double numerodigitado = double.Parse(Console.ReadLine());
                soma += numerodigitado;
            }
            Console.WriteLine($"A soma total é: {soma}");
        }
    }
}