using System;
using MetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Enums.Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.Pow(Radius,2) * Math.PI;
        }
        public override string ToString()
        {
            return $"Circle - Radius: {Radius}, {base.ToString()}";
        }
    }
}
