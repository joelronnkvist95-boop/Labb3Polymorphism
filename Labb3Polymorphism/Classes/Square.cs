using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3Polymorphism.Classes
{
    // Skapar klassen Square som ärver från klassen Geometry
    public class Square : Geometry
    {

        // Skapar här alla properties som krävs för att göra beräkningen av geometrins area
        double Side { get; set; }

        // Här tilldelas egenskaperna värden för beräkning av arean
        public Square()
        {
            Side = 19.3;
        }
        // Här sker polymorphismen av Area metoden som deklareras i basklassen.
        // Metoden skrivs om beroende på hur arean av den geometrin beräknas.
        public override double Area()
        {
            double area = Side * Side;
            return area;
        }
    }
}
