using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Hierarchy
{
    public class Shape
    {
       public string ShapeType;
        double Area;
        double perimeter;
        public Shape()
        {
            area = 0;
            Perimeter = 0;
            Console.WriteLine("**********************************");
        }
        public virtual double area { get { return Area; } set { Area = value; } }
        public virtual double Perimeter { get { return perimeter; } set { perimeter = value; } }



    }
}
