using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication143
{
    class Game3 : Game2
    {
        public List<Step> Steps = new List<Step>();

        void Step(int value)
        {
            Step temp_step = new Step();
            temp_step.val = value;
            temp_step.before = GetLocation(value);
            Shift(value);
            temp_step.after = GetLocation(value);
        }
    }
}
