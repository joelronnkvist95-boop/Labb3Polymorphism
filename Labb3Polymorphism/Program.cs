using Labb3Polymorphism.Classes;

namespace Labb3Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Skapar här en lista där jag lägger varje geomtryobjekt jag skapar.
            List<Geometry> geometry = new List<Geometry>();

            // Här skapar jag dem olika geometryobjekten.
            Geometry circle = new Circle();
            Geometry rectangle = new Rectangle();
            Geometry square = new Square();

            // Här lägger jag till de nyskapade objekten i Geometrylistan
            geometry.Add(circle);
            geometry.Add(rectangle);
            geometry.Add(square);

            // Jag loopar här igenom listan och skapar variabeln "g" för varje objekt i listan "geometry"
            
            foreach (Geometry g in geometry)
            {
                // Sen sparar jag det returnerade resultatet från metodanropen i variabeln area.
                double area = g.Area();

                // Här skriver jag ut resultatet med hjälp av en if-sats som går igenom vilken objekttyp det är.
                // För att skriva ut vilken objekttyp det är och dess area.
                if (g == circle)
                {
                    Console.WriteLine($"Area of Circle: {area}");
                }
                else if (g == rectangle)
                {
                    Console.WriteLine($"Area of Rectangle: {area}");
                }
                else
                {
                    Console.WriteLine($"Area of Square: {area}");
                }
                
                
            }
            


        }
    }
}
