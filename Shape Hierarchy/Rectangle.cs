using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Hierarchy
{
    public class Rectangle:Shape
    {
        double Width;
        double Height;
        public Rectangle()
        {
            ShapeType = "Rectanle";
            Console.WriteLine("Enter Width of the Rectangle");
            Width =double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height of the Rectangle");
            Height =double.Parse(Console.ReadLine());   
        }
        public override double Perimeter =>2*(Width+Height);
        public override double area => Width*Height;

        public void PrintInfo()
        {
            Console.WriteLine($"Shape Type  :{ShapeType}");
            Console.WriteLine($"Width & Height of {ShapeType} is  :{Width} and {Height}");
            Console.WriteLine($"Area of {ShapeType} is  :{area}");
            Console.WriteLine($"Permiter of {ShapeType} is   :{Perimeter}");
        }
    }

    
}
