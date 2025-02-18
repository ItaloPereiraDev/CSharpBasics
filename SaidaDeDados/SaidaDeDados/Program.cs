using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bom dia!");//Com quebra de linha
            Console.Write("Bom dia sem writeline, só com write!");//Sem quebra de linha
            double x = 4.20491337;
            Console.WriteLine(x);
            //Limitando a quantidade de casas decimais
            Console.WriteLine(x.ToString("F3"));
            //Desconsidera formatação específica de país (Usa o . no lugar da ,)
            Console.WriteLine(x.ToString("F3", CultureInfo.InvariantCulture));

            string nome = "Maria";
            int idade = 30;
            Console.WriteLine("{0} tem {1} anos e tem {2:F1} reais na conta", nome, idade, x);
            Console.WriteLine($"{nome} tem {idade} anos e tem {x.ToString("F1", CultureInfo.InvariantCulture)} reais na conta");
            Console.WriteLine(nome + " tem " + idade + " anos e tem " + x.ToString("F1") + " reais na conta.");
        }
    }
}