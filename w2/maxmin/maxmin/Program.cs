using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxmin
{
    public class Class1
    {
        static void Main(string[] args)
        {

            string line2 = File.ReadAllText(@" C: \Users\User\Desktop\PP2Labs\w2\maxmin\test.txt");
            string[] line = line2.Split(' ');

            int maxx = -10000000;
            int minn = 10000000;
            foreach (string s in line)
            {
                maxx = Math.Max(maxx, int.Parse(s));
                minn = Math.Min(minn, int.Parse(s));

            }
            Console.WriteLine("Minimum number is ");
            Console.WriteLine(minn);
            Console.WriteLine("Maximum number is");
            Console.WriteLine(maxx);

            Console.ReadKey();

        }
    }
}
