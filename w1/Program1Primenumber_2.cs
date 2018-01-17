using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ok = true;
            string s = Console.ReadLine();/* стринг аламыз "1 2 3 4 5"*/
            string[] arr = s.Split(' '); /* жеке сан ретинде болип аламыз {"1","2","3","4","5"} */
            int[] array = new int[arr.Length]; /* жана массив аламыз*/
            for (int i = 0; i < array.Length; i++) /* массив аркылы журемиз */
            {
                array[i] = int.Parse(arr[i]);   /* Массивтеги барлык элементтерди санга айналдырамыз */
            }
            foreach (int q in array) /* массивпен журемиз */
            {
                for (int j = 2; j <= Math.Sqrt(q); j++) /* жай санга тексеремиз */
                {
                    if (q % j == 0)
                    {
                        ok = false;
                        break;
                    }
                    else
                    {
                        ok = true;
                    }

                }
                if (ok && q != 1)
                {
                    Console.WriteLine(q);
                }
                else
                {
                    continue;
                }

            }
            Console.ReadKey();
        }
    }
}
