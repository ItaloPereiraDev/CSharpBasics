using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string frase = Console.ReadLine();
            //Console.WriteLine("Você digitou " + frase);
            //string[] palavrasSeparadas = Console.ReadLine().Split(' ');
            //Console.WriteLine($"As primeiras 3 palavras são: {palavrasSeparadas[0]}, {palavrasSeparadas[1]} e {palavrasSeparadas[2]}.");
            //int n1 = int.Parse(Console.ReadLine());
            //char c = char.Parse(Console.ReadLine());
            //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] infopessoa = Console.ReadLine().Split(' ');
            string nome = infopessoa[0];
            char sexo = char.Parse(infopessoa[1]);
            int idade = int.Parse(infopessoa[2]);
            double altura = double.Parse(infopessoa[3]);
            Console.WriteLine($"Nome:{nome} Sexo:{sexo} Idade:{idade} Altura:{altura.ToString("F2")}");

        }
    }
}