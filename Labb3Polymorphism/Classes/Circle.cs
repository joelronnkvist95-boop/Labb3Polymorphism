using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3Polymorphism.Classes
{
    
    // Skapar klassen Circle som ärver från klassen Geometry
    public class Circle : Geometry
    {
        
        // Skapar här alla properties som krävs för att göra beräkningen av geometrins area
        public double Radius { get; set; }

        public double Diameter { get; set; }

        public double Pi { get; set; }

        // Här tilldelas egenskaperna värden för beräkning av arean
        public Circle()
        {
            Radius = 5.2;

            Diameter = 10.4;

            Pi = 3.141;
        }

        // Här sker polymorphismen av Area metoden som deklareras i basklassen.
        // Metoden skrivs om beroende på hur arean av den geometrin beräknas.
        public override double Area()
        {
            double area = Radius * Radius * Pi;
            return area;
        }
    }
}
