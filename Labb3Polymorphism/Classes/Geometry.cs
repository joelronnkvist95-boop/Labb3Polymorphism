using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Labb3Polymorphism.Classes
{
    // Här gör jag basklassen till abstract typ för att inga objekt ska kunna skapas av klassen.
    // Också för att göra en abstract metoddeklarering för metoden Area();
    public abstract class Geometry
    {

        // Också för att göra en abstract metoddeklarering för metoden Area();
        public abstract double Area();

    }
}
