using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    [Serializable]
    class Snake
    {
        public List<Point> body;
        public string sign;
        public ConsoleColor color;
        public int cnt;

        public Snake()
        {
            body = new List<Point>();
            body.Add(new Point(10, 10));
            sign = "o";
            color = ConsoleColor.Yellow;
            cnt = 0;
        }

        public void Move(int dx, int dy)
        {
            cnt++;
            Console.SetCursorPosition(body[body.Count - 1].x, body[body.Count - 1].y);
            Console.Write(" ");
            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }

            body[0].x = body[0].x + dx;
            body[0].y = body[0].y + dy;

            if (body[0].x < 0)
            {
                body[0].x = Console.WindowWidth - 1;
            }
            if (body[0].x > Console.WindowWidth - 1)
            {
                body[0].x = 0;
            }
            if (body[0].y < 0)
            {
                body[0].y = Console.WindowHeight - 1;
            }
            if (body[0].y > Console.WindowHeight - 1)
            {
                body[0].y = 0;
            }
        }
        public void Draw()
        {
            int index = 0;

            foreach (Point p in body)
            {
                if (index == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = color;
                }
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
                index++;
            }
        }
        public bool ColllisionWithWall(Wall w)
        {
            foreach (Point p in w.body)
            {
                if (p.x == body[0].x && p.y == body[0].y)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Collision()
        {
            for (int i = 1; i < body.Count; i++)
            {
                if (body[0].x == body[i].x && body[0].y == body[i].y)
                {
                    return true;
                }
            }
            return false;
        }
        /*public bool Collisionwall(Wall w, int t , int s)
        {
            foreach(Point p in w.body)
            {
                if(t==p.x && s == p.y)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CollisionWithSnake(int t, int s)
        {
            foreach(Point p in body)
            {
                if(t==p.x && s == p.y)
                {
                    return true;
                }
            }
            return false;
        }*/
    }
}
