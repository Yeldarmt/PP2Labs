using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complex_number
{
    class Complex
    {
        public int a, b;

        public Complex(int _a, int _b)
        {
            a = _a;
            b = _b;

        }

       

        public Complex Add(Complex complex2)
        {
            Complex result = new Complex(this.a * complex2.b + complex2.a * this.b, this.b * complex2.b);

            return result;
        }
        public Complex Minus(Complex complex2)
        {
            Complex result = new Complex(this.a * complex2.b - complex2.a * this.b, this.b * complex2.b);

            return result;
        }
        public Complex Multiple(Complex complex2)
        {
            Complex result = new Complex(this.a * complex2.a, this.b * complex2.b);

            return result;
        }
        public Complex Division(Complex complex2)
        {
            Complex result = new Complex(this.a * complex2.b, this.b * complex2.a);

            return result;
        }

        
        public void Simplify()
        {
            int _a = this.a;
            int _b = this.b;
            while (_a > 0 && _b > 0)
            {
                if (_a > _b)
                    _a = _a % _b;
                else
                    _b = _b % _a;
            }
            int nod = _a + _b;
            a /= nod;
            b /= nod;
        }
        public override string ToString()
        {
            return a + "/" + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            string line = Console.ReadLine();
            string[] s = line.Split(' ');
            string a = s[0];
            string b = s[1];
            string[] d = a.Split('/');
            string[] v = b.Split('/');

            int a1 = int.Parse(d[0]);
            int a2 = int.Parse(d[1]);
            int b1 = int.Parse(v[0]);
            int b2 = int.Parse(v[1]);

            Complex t1 = new Complex(a1, a2);
            Complex t2 = new Complex(b1, b2);
            Complex t3 = t1.Add(t2);
            Complex t4 = t1.Minus(t2);
            Complex t5 = t1.Multiple(t2);
            Complex t6 = t1.Division(t2);
            t3.Simplify();
            t4.Simplify();
            t5.Simplify();
            t6.Simplify();

            Console.WriteLine("sum = " + t3);
            Console.WriteLine("subtract = " + t4);
            Console.WriteLine("product = " + t5);
            Console.WriteLine("division = " + t6);

            Console.ReadKey();

        }
    }
}