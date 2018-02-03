using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //int level = 1;
            Snake snake = new Snake();
            Wall wall = new Wall();
            while(true){
                try
                {
                    /*Console.Clear();
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(x, y);
                    Console.Write("*");*/
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.UpArrow)
                        snake.Move(0, -1);
                    if (keyInfo.Key == ConsoleKey.DownArrow)
                        snake.Move(0, 1);
                    if (keyInfo.Key == ConsoleKey.LeftArrow)
                        snake.Move(-1,0);
                    if (keyInfo.Key == ConsoleKey.RightArrow)
                        snake.Move(1, 0);
                    
                }
                catch(Exception e)
                {
                    Console.WriteLine("ERROR!");
                    Console.ReadKey();
                }
                Console.Clear();
                snake.Draw();
                wall.Draw();
            }
        }
    }
}
