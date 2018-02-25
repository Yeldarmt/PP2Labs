using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Snake
{
    [Serializable]
    class Program
    {

        static int direction = 1;
        static int level = 1;
        static Snake snake = new Snake();
        static Wall wall = new Wall(level);
        static Random rdm = new Random();
        static int t = rdm.Next(0, 54);
        static int s = rdm.Next(0, 24);
        static int score = 0;
        static int speed = 175;
        static int record = 0;

        public static void func()
        {
            while (true)
            {
                while (!(snake.Collisionwall(wall, t, s)) || !(snake.CollisionWithSnake(t, s)))
                {
                    if ((t == snake.body[0].x && s == snake.body[0].y))
                    {
                        snake.body.Add(new Point(t, s));
                        score++;
                        t = rdm.Next(0, 54);
                        s = rdm.Next(0, 24);
                        if (score % 3 == 0)
                        {
                            level++;
                            Console.Clear();
                            snake = new Snake();
                            wall = new Wall(level);
                        }
                    }
                    if (direction == 8)
                    {
                        snake.Move(0, -1);
                    }
                    if (direction == 2)
                    {
                        snake.Move(0, 1);
                    }
                    if (direction == 6)
                    { 
                        snake.Move(1, 0);
                    }
                    if (direction == 4)
                    {
                        snake.Move(-1, 0);
                    }
                    if (snake.ColllisionWithWall(wall) || snake.Collision())
                    {
                        Console.Clear();
                        Console.SetCursorPosition(20, 10);
                        Console.WriteLine("GAME OVER!!!");
                        F0(record);
                        F1(record);
                        score = 0;
                        Console.ReadKey();
                        Console.Clear();
                        snake = new Snake();
                        level = 1;
                        wall = new Wall(level);
                    }
                    //F2();

                    Console.SetCursorPosition(t, s);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Q");

                    snake.Draw();
                    wall.Draw();
                    Thread.Sleep(speed);
                }
            }
        }

        static void F0(int record)
        {
            XmlSerializer xs = new XmlSerializer(typeof(int));
            FileStream fs = new FileStream("record.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            xs.Serialize(fs, record);
            fs.Close();
        }
        static void F1(int record)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("record.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            bf.Serialize(fs, record);
            fs.Close();
        }
       /* static void F2()
        {
            XmlSerializer xs = new XmlSerializer(typeof(int));
            FileStream fs = new FileStream("record.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            string r = xs.Deserialize(fs) as string ;
            Console.SetCursorPosition(1, 28);
            Console.WriteLine("RECORD : " + r);
        }*/

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(60, 30);

            Console.SetCursorPosition(5, 10);
            Console.WriteLine("Enter your name : ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(25, 10);
            string name = Console.ReadLine();
            Console.Clear();

            Thread thread = new Thread(func);
            thread.Start();

            Console.SetCursorPosition(t, s);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Q");

            while (true)
            {
                Console.SetCursorPosition( 1,27);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(name);
              //  score = snake.body.Count-1;
                Console.SetCursorPosition(name.Length+2,27);
                record = Math.Max(record, score);
                Console.WriteLine("Score : " + score);
                ConsoleKeyInfo k = Console.ReadKey();

                //F2();

                if (k.Key == ConsoleKey.UpArrow && direction != 2)
                    direction = 8;
                if (k.Key == ConsoleKey.DownArrow && direction != 8)
                    direction = 2;
                if (k.Key == ConsoleKey.RightArrow && direction != 4)
                    direction = 6;
                if (k.Key == ConsoleKey.LeftArrow && direction != 6)
                    direction = 4;
            }
            

        }
    }
}
