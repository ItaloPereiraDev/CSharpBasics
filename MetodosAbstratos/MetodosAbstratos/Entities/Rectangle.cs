using System;
using MetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos.Entities
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Enums.Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
        public override string ToString()
        {
            return $"Rectangle - Width: {Width}, Height: {Height}, {base.ToString()}";
        }
    }
}
