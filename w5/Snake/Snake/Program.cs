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
            Console.CursorVisible = false;
           // int level = 1;
            Snake snake = new Snake();
         //   Wall wall = new Wall(level);

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.DownArrow)
                    snake.Move(0, 1);
                if (keyInfo.Key == ConsoleKey.UpArrow)
                    snake.Move(0, -1);
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                    snake.Move(-1, 0);
                if (keyInfo.Key == ConsoleKey.RightArrow)
                    snake.Move(1, 0);
                if (keyInfo.Key == ConsoleKey.R)
                {
             //       level = 1;
                    snake = new Snake();
                   // wall = new Wall(level);
                }
                if(/*snake.CollisionWithWall(wall) ||*/ snake.Collision())
                {
                    Console.Clear();
                    Console.SetCursorPosition(50, 10);
                    Console.WriteLine("GAME OVER!!!");
                    Console.ReadKey();
                    snake = new Snake();
                    //level = 1;
                   // wall = new Wall(level);
                }
                /*if (snake.cnt % 400 == 0)
                {
                    level++;
                    wall = new Wall(level);
                }*/
                Console.Clear();
                snake.Draw();
               // wall.Draw();
            }
        }
    }
}
