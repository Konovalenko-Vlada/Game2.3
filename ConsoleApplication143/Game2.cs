using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication143
{
    class Game2 : Game
    {
        void Random()
        {
            Random rand = new Random();

            Coordinate zero = base.GetLocation(0);
            int rand_index_x = rand.Next(-1,1);
            int rand_index_y = rand.Next(-1, 1);

            zero.x += rand_index_x;
            zero.y += rand_index_y;

            int val = this[zero.x, zero.y];
            Shift(val);
        }

        public bool Result
        {
            get
            {
                int k = 0;
                for (int i = 0; i < Math.Sqrt(Val.Length) - 1; i++)
                {
                    for (int j = 0; j < Math.Sqrt(Val.Length) - 1; j++)
                    {
                        if (Val[i, j] != k++ || Val[((int)(Math.Sqrt(Val.Length) - 1)), ((int)(Math.Sqrt(Val.Length) - 1))] != 0) //****
                        {
                            return false;
                        }
                    }
                }
                return true;
             } 
        }

    }
}
