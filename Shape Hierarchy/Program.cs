using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Hierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the Circle");
            double r=double.Parse(Console.ReadLine());
            Circle c=new Circle(r);
            c.PrintInfo();

            Rectangle R = new Rectangle();
            R.PrintInfo();

            Triangle t = new Triangle();
            t.PrintInfo();

            Console.ReadKey();

        }
    }
}
