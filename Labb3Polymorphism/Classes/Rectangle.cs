using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3Polymorphism.Classes
{
    internal class Rectangle : Geometry
    {
        double Height { get; set; }
        double Width { get; set; }
        public override double Area()
        {
            double area = Height * Width;
            return area;
        }
    }
}
