using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcircle
{
    class Circle
    {
        public double r;
        public double s;
        public double d;
        public double l;

        public Circle()
        {
            r = 5;
            FindArea();
            FindDiametr();
            FindCircumference();
        }

        public Circle(double r)
        {
            this.r = r;
            FindArea();
            FindDiametr();
            FindCircumference();

        }
        public void FindArea()
        {
            s = Math.PI * r * r;
        }
        public void FindDiametr()
        {
            d = 2 * r;
        }
        public void FindCircumference()
        {
            l = 2 * Math.PI * r;
        }
        public override string ToString()
        {
            return "Area = " + s + "\nDiametr = " + d + "\nCircumference = " + l;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius of circum");
            double r = int.Parse(Console.ReadLine());
            Circle c = new Circle(r);
            Console.WriteLine(c);
            Console.WriteLine("The Next Circle :");
            Circle c2 = new Circle();
            Console.WriteLine(c2);
            Console.ReadKey();
        }
    }
}
