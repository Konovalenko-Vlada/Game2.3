﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication143
{
    class Game
    {
        public List<Coordinate> Coords = new List<Coordinate>();
        public int[,] Val;
        int c = 0;

        public Game(params int[] data)
        {
            if (Math.Sqrt(data.Length) % 1 != 0)
            {
                throw new ArgumentException("Error Size!!!");
            }

            for (int i = 1; i <= data.Length; i++ )
            {
                Coords.Add(new Coordinate());
            }

            int index = 0;

            for (int i = 0; i < Math.Sqrt(data.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(data.Length); j++)
                {
                    Coords[index].x = i + 1;
                    Coords[index].y = j + 1;
                    Coords[index].filled = true;
                    index++;
                    Val[i, j] = c++;
                }
            }
        }

        public Game(params string[] data)
        {
            if (Math.Sqrt(data.Length) % 1 != 0)
            {
                throw new ArgumentException("Error Size!!!");
            }

            for (int i = 0; i < Math.Sqrt(data.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(data.Length); j++)
                {
                    Coordinate temp_Coordinate = new Coordinate();
                    temp_Coordinate.x = i++;
                    temp_Coordinate.y = j++;
                    Coords[Convert.ToInt32(data[i + j])] = temp_Coordinate;

                    //val[i, j] = c++;
                }
            }
        }

        public int this[int x, int y]
        {
            get
            {
                //return Coords.FindIndex(coord => (coord.x == x) && (coord.y == y));
                return Val[x, y];
            }
        }

        public Coordinate GetLocation(int value)
        {
            return Coords[value];
        }

        public void Shift(int value)
        {
            Coordinate zero = GetLocation(0);
            Coordinate val = GetLocation(value);

            if (Math.Abs(zero.x - val.x) == 1 || Math.Abs(zero.y - val.y) == 1)
            {
                Coordinate prom = zero;
                zero = val;
                val = prom;
            }
            else
            {
                throw new ArgumentException("Error no empty space!!!");
            }
        }

        public static Game FromCSV(string file)
        {
            string[] data = File.ReadAllText(file).Split(';');
            return new Game(data);
        }
    }
}

