using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Wall
    {
        public List<Point> body;
        public string sign;
        public ConsoleColor color;

        /*public void ReadLevel(int level)
        {
            StreamReader sr=new StreamReader(@"C:\Desktop")
                int n = int.Parse(sr.Readline());
            for (int i = 0; i < n; i++)
            {
                if(sr[j])
            }
        }*/
        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }
    }
}
