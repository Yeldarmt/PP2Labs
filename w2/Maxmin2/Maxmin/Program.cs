using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Maxmin
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = File.ReadAllText(@"C:\Users\User\Desktop\PP2Labs\w2\Maxmin2\Maxmin\numbers\input.txt");
            string[] t = s.Split(' ');
            int maxx = -123345;
            int minn = 12345;
            foreach(string d in t)
            {
                maxx = Math.Max(maxx, int.Parse(d));
                minn = Math.Min(minn, Convert.ToInt32(d));
            }
           /* foreach(string d in t)
            {
                if (int.Parse(d) < minn)
                {
                    minn = int.Parse(d);
                }
                if (int.Parse(d) > maxx)
                {
                    maxx = int.Parse(d);
                }
            }*/
            Console.WriteLine("The maximum number is : " + maxx);
            Console.WriteLine("The minimum number is : " + minn);
            Console.ReadKey();
        }
    }
}
