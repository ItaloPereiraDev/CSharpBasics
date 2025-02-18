using System;
using MembrosEstaticos;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre o valor do raio:");
            double raio = double.Parse(Console.ReadLine());

            Console.WriteLine($"A Circunferência é: {Calculadora.Circunf(raio).ToString("F2")}");
            Console.WriteLine($"O Volume é: {Calculadora.Vol(raio).ToString("F2")}");
            Console.WriteLine($"Valor de Pi: {Math.PI.ToString("F2")}");
        }
    }
}