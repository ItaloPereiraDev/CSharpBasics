﻿using MetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos.Entities
{
    internal abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }
        public abstract double Area();
        public override string ToString()
        {
            return $"Color: {Color}, Area: {Area():F2}";
        }
    }
}
