using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Serdi
{
    class Complex
    {
        public int a, b;
        public Complex(int _a, int _b)
        {
            a = _a;
            b = _b;
        }
        public Complex Add(Complex l)
        {
            Complex r = new Complex(this.a * l.b + this.b * l.a, this.b * l.b);
                return r;
        }
        public Complex Minus(Complex l)
        {
            Complex r = new Complex(this.a * l.b - this.b * l.a, this.b * l.b);
            return r;
        }
        public Complex Multiple(Complex l)
        {
            Complex r = new Complex(this.a * l.a, this.b * l.b);
            return r;
        }
        public Complex Div(Complex l)
        {
            Complex r = new Complex(this.a * l.b, this.b * l.a);
            return r;
        }
        public override string ToString()
        {
            return a + "/" + b;
        }
        public void Simplify()
        {
            int _a = this.a;
            int _b = this.b;
            while(_a>0 && _b > 0)
            {
                if (_a > _b)
                {
                    _a %= _b;
                }
                else
                {
                    _b %= _a;
                }
            }
            int gcd = _a + _b;
            a /= gcd;
            b /= gcd;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] l = line.Split(' ');
            string b1 = l[0];
            string b2 = l[1];
            string[] c1 = b1.Split('/');
            string[] c2 = b2.Split('/');
            int a1 = int.Parse(c1[0]);
            int a2 = int.Parse(c1[1]);
            int s1 = int.Parse(c2[0]);
            int s2 = int.Parse(c2[1]);

            Complex t1 = new Complex(a1, a2);
            Complex t2 = new Complex(s1, s2);
            Complex t3 = t1.Add(t2);
            Complex t4 = t1.Minus(t2);
            Complex t5 = t1.Multiple(t2);
            Complex t6 = t1.Div(t2);

            t3.Simplify();
            t4.Simplify();
            t5.Simplify();
            t6.Simplify();

            Console.WriteLine("The sum of two elements is = " + t3);
            Console.WriteLine("The subtract of two elements is = " + t4);
            Console.WriteLine("The product of two elements is = " + t5);
            Console.WriteLine("The division of two elements is = " + t6);
            Console.ReadKey();

        }
    }
}
