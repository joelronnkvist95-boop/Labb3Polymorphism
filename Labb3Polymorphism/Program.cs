using Labb3Polymorphism.Classes;

namespace Labb3Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Geometry> geometry = new List<Geometry>();

            Geometry circle = new Circle();
            Geometry rectangle = new Rectangle();
            Geometry square = new Square();

            geometry.Add(circle);
            geometry.Add(rectangle);
            geometry.Add(square);

            foreach (Geometry g in geometry)
            {
                double area = g.Area();

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
