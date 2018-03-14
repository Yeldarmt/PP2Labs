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
        static int speed = 200;
        static int record = 0;

        public static void func()
        {
            while (true)
            {

                if ((t == snake.body[0].x && s == snake.body[0].y))
                {
                    snake.body.Add(new Point(t, s));
                    score++;
                    speed = Math.Max(50, speed - 25);
                    // t = rdm.Next(0, 54);
                    //s = rdm.Next(0, 24);

                    CreateFood();
                    if (score % 3 == 0)
                    {
                        level++;
                        Console.Clear();
                        for (int i = 0; i < snake.body.Count; ++i)
                        {
                            snake.body[i].x = i + 10;
                            snake.body[i].y = 15;
                        }
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
                    speed = 300;
                    F1(record);
                    score = 0;
                    Console.ReadKey();
                    Console.Clear();
                    snake = new Snake();
                    level = 1;
                    wall = new Wall(level);
                }

                Console.SetCursorPosition(t, s);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Q");
                snake.Draw();
                wall.Draw();
                Thread.Sleep(speed);

            }
        }
        static void CreateFood()
        {
            while (true)
            {

                int k = 0;
                rdm = new Random();
                t = rdm.Next(0, 54);
                s = rdm.Next(0, 24);
                for (int i = 0; i < wall.body.Count; ++i)
                {
                    for (int j = 0; j < snake.body.Count; ++j)
                    {
                        if ((snake.body[j].x == t && snake.body[j].y == s) || (wall.body[i].x == t && wall.body[i].y == s))
                            k = 1;
                    }
                }
                if (k == 0)
                {
                    Console.SetCursorPosition(t, s);
                    Console.WriteLine("Q");
                    break;
                }
            }
        }
        
        static void F1(int record)
        {
            StreamWriter sr = new StreamWriter(@"C:\Users\User\Desktop\PP2Labs\Snake\Snake\bin\Debug\record.txt");
            sr.WriteLine(record);
            sr.Close();
        }
        static int F2()
        {
            StreamReader sr = new StreamReader(@"C:\Users\User\Desktop\PP2Labs\Snake\Snake\bin\Debug\record.txt");
            string line = sr.ReadLine();
            int n;
            sr.Close();
            n = int.Parse(line);
            return n;
        }
        static void F3(Snake snake)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("data2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            bf.Serialize(fs, snake);
            fs.Close();
            
        }
        static Snake F4()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("data2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Snake snake=bf.Deserialize(fs) as Snake;
            fs.Close();
            return snake;
        }
        static void F5(Wall wall)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("asdf.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            bf.Serialize(fs, wall);
            fs.Close();
        }
        static Wall F6()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("asdf.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Wall wall = bf.Deserialize(fs) as Wall;
            fs.Close();
            return wall;
        }
        static void Main(string[] args)
        {
            record=F2();
            Console.CursorVisible = false;
            Console.SetWindowSize(60, 30);

            Console.SetCursorPosition(5, 10);
            Console.WriteLine("Enter your name : ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(25, 10);
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("If you want to continue type 2");
            ConsoleKeyInfo ki = Console.ReadKey();
                Console.Clear();        
            if (ki.Key == ConsoleKey.NumPad2)
            {
                  snake=F4();
                wall = F6();
            }

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
                Console.SetCursorPosition(name.Length+2,27);
                record = Math.Max(record, score);
                Console.WriteLine("Score : " + score);
                Console.WriteLine("Record: " + record);
                ConsoleKeyInfo k = Console.ReadKey();

                if (k.Key == ConsoleKey.UpArrow && direction != 2)
                    direction = 8;
                if (k.Key == ConsoleKey.DownArrow && direction != 8)
                    direction = 2;
                if (k.Key == ConsoleKey.RightArrow && direction != 4)
                    direction = 6;
                if (k.Key == ConsoleKey.LeftArrow && direction != 6)
                    direction = 4;
                if (k.Key == ConsoleKey.S)
                {
                    F3(snake);
                    F5(wall);
                }
                
            }      
        }
    }
}
