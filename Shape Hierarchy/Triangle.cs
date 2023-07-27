using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Hierarchy
{
    public class Triangle:Shape
    {
        double SideA;
        double SideB;
        double SideC;

        public Triangle()
        {
            ShapeType = "Triangle";
            Console.WriteLine("Enter the value of Side-A");
            SideA =double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of Side-B");
            SideB = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of Side-C");
            SideC = double.Parse(Console.ReadLine());
        }
        public override double Perimeter =>SideA+SideB+SideC ;
        public override double area
        {
            get
            {
                double result = (SideA + SideB + SideC) / 2;
                return Math.Sqrt(result * (result - SideA) * (result - SideB)*(result - SideC));
            }
            set { double result = value; }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Shape Type  :{ShapeType}");
            Console.WriteLine($"Sides of {ShapeType} is  :{SideA},{SideB} and {SideC}");
            Console.WriteLine($"Area of {ShapeType} is  :{area}");
            Console.WriteLine($"Permiter of {ShapeType} is   :{Perimeter}");
        }
    }

}
