using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3Polymorphism.Classes
{
    internal class Geometry
    {
        double GeometryArea { get; set; }


        public virtual double Area()
        {
            double area = GeometryArea;
            return area;
        }
    }
}
