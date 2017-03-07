using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication143
{
    class Step
    {
        public int Val;
        public Coordinate Before;
        public Coordinate After;

        public Step(int val = 0, Coordinate before = null, Coordinate after = null)
        {
            Val = val;
            Before = before;
            After = after;
        }
    }
}
