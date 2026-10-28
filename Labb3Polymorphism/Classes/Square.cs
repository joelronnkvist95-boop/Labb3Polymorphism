using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3Polymorphism.Classes
{
    public class Square : Geometry
    {
        double Side { get; set; }

        public Square()
        {
            Side = 19.3;
        }
        public override double Area()
        {
            double area = Side * Side;
            return area;
        }
    }
}
