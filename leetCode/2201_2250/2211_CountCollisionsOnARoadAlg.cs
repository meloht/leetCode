using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2201_2250
{
    public class _2211_CountCollisionsOnARoadAlg
    {
        public int CountCollisions1(string directions)
        {
            string s = directions.TrimStart('L').TrimEnd('R');

            return s.Length - s.Count(p => p == 'S');
        }

        public int CountCollisions(string directions)
        {

            int left = -1;
            int right = directions.Length;
            int s = 0;
            int num = directions.Length;
            for (int i = 0; i < directions.Length; i++)
            {
                if (directions[i] == 'L')
                {
                    left = i;
                    num--;
                }
                else
                {
                    break;
                }
            }
            for (int i = directions.Length - 1; i >= 0; i--)
            {
                if (directions[i] == 'R')
                {
                    right = i;
                    num--;
                }
                else
                {
                    break;
                }
            }

            for (int i = left + 1; i < right; i++)
            {
                if (directions[i] == 'S')
                {
                    s++;
                }
            }
            return num - s;
        }
    }
}
