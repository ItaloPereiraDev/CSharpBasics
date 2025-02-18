using System;
using System.Globalization;
using System.Runtime.Serialization;
using PrimeiraAulaObjetosTriangulo;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();

            y = new Triangulo();

            Console.WriteLine("Digite as medidas do primeiro triângulo:");
            x.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite as medidas do segundo triângulo:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine($"Area X = {areaX:F2}");
            Console.WriteLine($"Area Y = {areaY:F2}");
            if (areaX > areaY)
            {
                Console.WriteLine($"Área X é a maior");
            }
            else if (areaX == areaY)
            {
                Console.WriteLine($"Áreas iguais");
            }
            else
            {
                Console.WriteLine($"Area Y é a maior");
            }

        }
    }
}