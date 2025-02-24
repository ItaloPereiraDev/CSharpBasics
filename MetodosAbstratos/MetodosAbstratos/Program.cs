using System;
using MetodosAbstratos.Entities;
using MetodosAbstratos.Entities.Enums;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapeList = new List<Shape>();
            Console.WriteLine("Enter the number of shapes:");
            int shapes = int.Parse(Console.ReadLine());
            for (int i = 1; i <= shapes; i++)
            {
                Console.WriteLine($"Shape #{i} Data:");
                Console.WriteLine("Rectangle or Circle?");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Color (Black/Blue/Red):");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (ch == 'r')
                {
                    Console.WriteLine("Width:");
                    double width = double.Parse(Console.ReadLine());
                    Console.WriteLine("Height:");
                    double height = double.Parse(Console.ReadLine());
                    shapeList.Add(new Rectangle(width, height, color));
                }
                else if (ch == 'c')
                {
                    Console.WriteLine("Radius:");
                    double radius = double.Parse(Console.ReadLine());
                    shapeList.Add(new Circle(radius, color));
                }
            }
            Console.WriteLine("Shape Areas:");
            foreach (Shape shape in shapeList)
            {
                Console.WriteLine(shape);
            }
        }
    }
}