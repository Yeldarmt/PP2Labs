using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();//стринг енгіземіз (1 2 3 4 5);
            string[] a = s.Split(' ');//пробелмен бөліп алып массивке саламыз(1,2,3,4,5); 
            int l = a.Length;//массив ұзындығын табамыз [5];
            for (int i = 0; i < l; i++)//массив бойынша жүреміз;
            {
                int n = int.Parse(a[i]);//массивтегі стрингті санға айналырады;
                int k = 0;
                for (int j = 2; j < n; j++)//2ден бастап саннын өзіне дейін жүріп өтеміз;
                {
                    if (n % j == 0)
                    {
                        k++;//бөлгіштернің санын есептейміз; 
                    }
                }
                if (k == 0)//егер ол 0ге тен болса жай сан болады;
                {
                    Console.Write(n + " ");//сол сандарды шыгарамыз;
                }
            }
            Console.ReadKey();
        }
    }
}
