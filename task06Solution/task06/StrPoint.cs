using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task06
{
    internal struct StrPoint
    {
        private int x;
        private int y;

        public StrPoint(int _X)
        {
            x = _X;
            y = 0;
        }
        public StrPoint(int _X, int _Y)
        {
            x = _X;
            y = _Y;
        }
        public override string ToString()
        {
            return $"({x},{y})";
        }
    }
}
