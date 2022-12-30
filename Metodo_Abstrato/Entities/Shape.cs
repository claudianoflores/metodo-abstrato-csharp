﻿using Metodo_Abstrato.Entities.Enums;

namespace Metodo_Abstrato.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
