using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3Polymorphism.Classes
{
    public class Rectangle : Geometry
    {
        double Height { get; set; }
        double Width { get; set; }

        public Rectangle()
        {
            Height = 13.37;
            Width = 18;
        }
        public override double Area()
        {
            double area = Height * Width;
            return area;
        }
    }
}
