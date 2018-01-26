using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursor1
{
    class Program
    {
        static void Main(string[] args)
        {
            int curX = 0, curY = 0;
            while (true)
            {
                Console.Clear();
                Console.CursorVisible = false;
                Console.SetCursorPosition(curX, curY);
                Console.Write("*");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                    curY--;
                if (keyInfo.Key == ConsoleKey.DownArrow)
                    curY++;
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                    curX--;
                if (keyInfo.Key == ConsoleKey.RightArrow)
                    curX++;
            }
        }
    }
}
