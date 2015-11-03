using System.Collections.Generic;
namespace Shapes
{
    class EntryPoint
    {
        static void Main()
        {
            Shape[] shapes = {
                 new Rectangle(3,2),
                 new Triangle(2,4),
                 new Triangle(4,2),
                 new Rectangle(6,2),
                 new Square(4)
           };
            foreach (var shape in shapes)
            {
                System.Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
