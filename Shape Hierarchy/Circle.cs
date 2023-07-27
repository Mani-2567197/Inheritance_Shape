using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Hierarchy
{
    public class Circle:Shape
    {
        double Radius;
        public Circle(double radius)
        {
            ShapeType = "Circle";
            Radius = radius;
        }
        public override double area =>Math.PI * Radius;
        public override double Perimeter  => 2 * Math.PI * Radius;

        public void PrintInfo()
        {
            Console.WriteLine($"Shape Type  :{ShapeType}");
            Console.WriteLine($"Radius of {ShapeType} is  :{Radius}");
            Console.WriteLine($"Area of {ShapeType} is  :{area}");
            Console.WriteLine($"Permiter of {ShapeType} is   :{Perimeter}");
        }
    }
}
