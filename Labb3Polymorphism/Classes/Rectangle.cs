using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3Polymorphism.Classes
{

    // Skapar klassen Rectangle som ärver från klassen Geometry
    public class Rectangle : Geometry
    {
        // Skapar här alla properties som krävs för att göra beräkningen av geometrins area
        double Height { get; set; }
        double Width { get; set; }

        // Här tilldelas egenskaperna värden för beräkning av arean
        public Rectangle()
        {
            Height = 13.37;
            Width = 18;
        }
        // Här sker polymorphismen av Area metoden som deklareras i basklassen.
        // Metoden skrivs om beroende på hur arean av den geometrin beräknas.
        // Det sker genom att låta varje subklass av Geometryklassen att skriva om metoderna på sitt eget sätt.
        public override double Area()
        {
            double area = Height * Width;
            return area;
        }
    }
}
