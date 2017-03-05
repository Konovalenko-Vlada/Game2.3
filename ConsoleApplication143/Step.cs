using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication143
{
    class Step
    {
        public int val;
        public Coordinate before;
        public Coordinate after;

        public Step(int val = 0, Coordinate before = null, Coordinate after = null)
        {
            this.val = val;
            this.before = before;
            this.after = after;
        }
    }
}
