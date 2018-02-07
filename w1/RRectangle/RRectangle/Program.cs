using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle
{
    class rectangle
    {
        public double w;
        public double h;
        public double s;
        public double p;
        public rectangle(double w, double h)
        {
            this.w = w;
            this.h = h;
            FindArea();
            FindPerimetr();
        }
        void FindArea()
        {
            this.s = w * h;

        }
        void FindPerimetr()
        {
            this.p = 2 * (w + h);
        }
        public override string ToString()
        {
            return "Area = " + s + "\nPerimetr = " + p;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter width :");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height :");
            double h = double.Parse(Console.ReadLine());
            rectangle rec = new rectangle(w, h);
            Console.WriteLine(rec);
            Console.ReadKey();
        }
    }
}