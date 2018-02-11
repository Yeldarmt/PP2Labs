using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake
    {
        List<Point> body;
        string sign;
        ConsoleColor color;
        public int cnt;
        public Snake()
        {
            body = new List<Point>();
            body.Add(new Point(10, 10));
            sign = "o";
            color = ConsoleColor.Yellow;
            cnt = 0;
        }
        public void Move(int dx,int dy)
        {
            cnt++;
            if (cnt % 20 == 0)
            {
                body.Add(new Point(0, 0));
            }

            for(int i=body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            body[0].x += dx;
            body[0].y += dy;

        }
        public void Draw()
        {
            int index = 0;
            foreach(Point p in body)
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
    }
}
