using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3Polymorphism.Classes
{
    internal class Square : Geometry
    {
        double Side { get; set; }
        public override double Area()
        {
            double area = Side * Side;
            return area;
        }
    }
}
