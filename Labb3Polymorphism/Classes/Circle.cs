using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3Polymorphism.Classes
{
    public class Circle : Geometry
    {
        public double Radius { get; set; }

        public double Diameter { get; set; }

        public double Pi { get; set; }

        public Circle()
        {
            Radius = 5.2;

            Diameter = 10.4;

            Pi = 3.141;
        }


        public override double Area()
        {
            double area = Radius * Radius * Pi;
            return area;
        }
    }
}
