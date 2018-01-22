using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle
{
    class program
    {
        class rectangle {
            double w, h, s, p;
            public rectangle(double w, double h)
            {
                this.w = w;
                this.h = h;
                findArea();
                findPerimetr();
                void findArea()
                {
                    this.s = w * h;
                }
                void findPerimetr()
                {
                    this.p = 2 * (w + h);
                }
            }
            public override string ToString()
            {
                return "Area = " + s + "\nPerimetr = " + p;
            }
        }
        static void Main(string[] args)
        {
        Console.WriteLine("Enter width:");
        double w = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height:");
        double h = double.Parse(Console.ReadLine());
        rectangle c = new rectangle(w, h);
        Console.WriteLine(c);
        Console.ReadKey();
        }
    }
}
