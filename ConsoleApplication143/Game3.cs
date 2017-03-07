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

        public override void Shift(int value)
        { 
                Step temp_step = new Step();
                temp_step.Val = value;
                temp_step.Before = GetLocation(value);

                base.Shift(value);
                temp_step.After = GetLocation(value);
           
        }

        public void step_back()
        {
            Steps.RemoveAt(Steps.Capacity-1);
        }
    }
}
