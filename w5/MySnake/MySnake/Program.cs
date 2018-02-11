using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Snake snake = new Snake();
            Console.CursorVisible = false;
            while (true)
            {
                ConsoleKeyInfo k = Console.ReadKey();
                if (k.Key == ConsoleKey.DownArrow)
                    snake.Move(0, 1);
                if (k.Key == ConsoleKey.UpArrow)
                    snake.Move(0, -1);
                if (k.Key == ConsoleKey.LeftArrow)
                    snake.Move(-1, 0);
                if (k.Key == ConsoleKey.RightArrow)
                    snake.Move(1, 0);

                Console.Clear();
                snake.Draw();
            }
        }
    }
}
