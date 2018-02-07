using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Wall
    {
        public List<Point> body;
        public string sign;
        public ConsoleColor color;

       /* public void ReadLevel(int a)
        {
            StreamReader sr = new StreamReader(@"level" + a + ".txt");
            int n = int.Parse(sr.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string s = sr.ReadLine();
                for (int j = 0; j < s.Length; j++)
                    if (s[j] == '*')
                        body.Add(new Point(j, i));
            }
            sr.Close();
        }*/
          /*  public Wall(int level)
            {
                body = new List<Point>();
                sign = "o";
                color = ConsoleColor.Magenta;
               // ReadLevel(level);
            }*/

            public void Draw()
            {
                Console.ForegroundColor = color;
                foreach(Point p in body)
                {
                    Console.SetCursorPosition(p.x, p.y);
                    Console.Write(sign);
                }
            }
        
    }
}
/*FileStream fs = new FileStream(@"level" + a + ".txt", FileMode.Open, FileAccess.Read);
StreamReader sr = new StreamReader(fs);
string s = sr.ReadLine();
            for (int i = 0; i<s.Length; i++)
            {
                for (int j = 0; j<s.Length; j++)
                {
                    if (s[j] == '*')
                        body.Add(new Point(j, i));
                }
                sr.Close();
            }*/

