using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication143
{
    class Game2 : Game
    {
        public Game2(params int[] data) : base(data)
        {
            Random rand = new Random();
            for (int i = 0; i < Coords.Count - 1; i++)
            {
                int rand_index = rand.Next(i, Coords.Count);
                Coordinate temp_coord = Coords[i];
                Coords[i] = Coords[rand_index];
                Coords[rand_index] = temp_coord;
            }
        }

        public bool Result()
        {
            int k = 0;
            for (int i = 0; i < Val.Length; i++)
            {
                for (int j = 0; j < Math.Sqrt(Val.Length); j++)
                {
                    if (Val[i, j] != k++)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
