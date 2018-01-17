using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    class circle
    {
        int r;
        public circle(int r)
        {
            this.r = r;
        }
        public static double findArea(int x)
        {
            double M_PI = 3.14d; 
            return (M_PI) * x* x;
        }
        public static int findDiameter(int x)
        {
            return 2 * x;
        }
        public static double findCircumference(int x)
        {
            double M_PI = 3.14d;
            return 2 * (M_PI) * x;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the radius?");
            int r = int.Parse(Console.ReadLine());
            circle wow = new circle(r);
            Console.WriteLine("Area is" +" "+ circle.findArea(r));
            Console.WriteLine("Diametre is" +" "+ circle.findDiameter(r));
            Console.WriteLine("Circumference is" +" "+ circle.findCircumference(r));
            Console.ReadKey();
        }
    }
}
