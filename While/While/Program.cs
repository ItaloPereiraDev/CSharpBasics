using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para obter a raiz quadrada. Atenção: Ao digitar um número negativo, o programa será encerrado.");

            double x = double.Parse(Console.ReadLine());
            while (x >= 0)
            {
                Console.WriteLine($"A raiz quadrada de {x} é {Math.Sqrt(x).ToString("F3")}");
                Console.WriteLine("Digite outro número:"); 
                x = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Número negativo!");
        }
    }
}