using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication143
{
    class Coordinate
    {
        public int x;
        public int y;
        public bool filled;

        public Coordinate(int x = 0, int y = 0, bool filled = false)
        {
            this.x = x;
            this.y = y;
            this.filled = filled;
        }
    }
}
