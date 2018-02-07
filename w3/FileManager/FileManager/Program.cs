using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File
{
    class Program
    {
        public static void File(int cur, FileSystemInfo[] fss)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            int index = 0;
            foreach (FileSystemInfo f in fss)
            {
                if (index == cur)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                index++;
                Console.WriteLine(f.Name);
            }
        }
        static void Main(string[] args)
        {
            int cur = 0;
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\User\Desktop\PP2Labs\w1");
            FileSystemInfo[] fss = directory.GetFileSystemInfos();
            File(cur, fss);
            /* foreach (FileSystemInfo k in fss)
             {
                 if (k.GetType() == typeof(FileInfo)){
                     Console.ForegroundColor = ConsoleColor.Yellow;
                     Console.WriteLine(k.Name);
                 }
                 else
                 {
                     Console.ForegroundColor = ConsoleColor.Red;
                     Console.WriteLine(k.Name);
                 }
             }*/
            while (true)
            {
                ConsoleKeyInfo k = Console.ReadKey();
                if (k.Key == ConsoleKey.UpArrow)
                {
                    cur--;
                    if (cur == -1)
                    {
                        cur = fss.Length - 1;
                    }
                }
                if (k.Key == ConsoleKey.DownArrow)
                {
                    cur++;
                    if (cur == fss.Length)
                    {
                        cur = 0;
                    }
                }
                if (k.Key == ConsoleKey.Enter)
                {
                    if (fss[cur].GetType() == typeof(DirectoryInfo))
                    {
                        cur = 0;
                        directory = new DirectoryInfo(fss[cur].FullName);
                        fss = directory.GetFileSystemInfos();
                    }
                    else
                    {

                        Console.Clear();
                        StreamReader sr = new StreamReader(fss[cur].FullName);
                        Console.WriteLine(sr.ReadToEnd());

                        Console.ReadKey();
                    }
                }
                if (k.Key == ConsoleKey.Escape || k.Key == ConsoleKey.Backspace)
                {
                    directory = directory.Parent;
                    fss = directory.GetFileSystemInfos();
                }
                Console.Clear();
                File(cur, fss);
            }
        }
    }
}

