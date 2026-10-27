using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3Polymorphism.Classes
{
    internal class Circle : Geometry
    {
        public double Radius { get; set; }

        public double Diameter { get; set; }

        public double Pi { get; set; }

        public Circle(double radius, double diameter)
        {
            Radius = radius;

            Diameter = diameter;

            Pi = 3.141;
        }


        public override double Area()
        {
            double area = Radius * Radius * Pi;
            return area;
        }
    }
}
