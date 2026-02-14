using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task06
{
    internal class Point
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }


        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point()
        {
            x = y = 0;
        }

        public Point(int _X, int _Y)
        {
            x = _X;
            y = _Y;
        }

        public override string ToString() { 
             return $"({x}, {y})";
        }


    }
}
