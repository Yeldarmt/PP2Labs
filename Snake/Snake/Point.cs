using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{[Serializable]
    class Point
    {
        public int x;
        public int y;
        public Point(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }
    }
}
