using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] arr = line.Split(' ');
            
            for(int i=0 ; i < arr.Length ; i++)
            {
                int k = 0;
                for (int j = 2; j < int.Parse(arr[i]); j++)
                {
                    
                    if ((int.Parse(arr[i])) % j == 0)
                    {
                        k++;
                    }
                }
                if (k == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            } 
            Console.ReadKey();

        }
    }
}
