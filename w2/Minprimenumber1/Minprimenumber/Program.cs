using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Minprimenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int f(int l)
            {
                int p = 0;
                for (int i = 1; i <= l; i++)
                {
                    if (l % i == 0)
                    {
                        p++;
                    }
                }
                return p;
            }
            int min = 123456;
            string s = File.ReadAllText(@"C: \Users\User\Desktop\PP2Labs\w2\Minprimenumber1\Minprimenumber\numbers.txt");
            string[] t = s.Split(' ');
            foreach(string d in t)
            {
                int c = int.Parse(d);
                if(f(c)==2 && min > c)
                {
                    min=c;
                }
            }
            // Console.WriteLine(min);
            StreamWriter sw = new StreamWriter(@"C:\Users\User\Desktop\PP2Labs\w2\Minprimenumber1\Minprimenumber\jauap.txt");
            sw.WriteLine(min);
            sw.Close();
            Console.ReadKey();
        }
    }
}
