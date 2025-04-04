using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _875_KokoEatingBananasAlg
    {
        public int MinEatingSpeed(int[] piles, int h)
        {
            int max = piles.Max();

            int left = 1;
            int right = max;

            int k = right;
            while (left <= right)
            {
                int speed = (right - left) / 2 + left;
                long time = GetTime(piles, speed);
                if (time <= h)
                {
                    k = speed;
                    right = speed - 1;
                }
                else
                {
                    left = speed + 1;
                }
            }
            return k;
        }

        private long GetTime(int[] piles, int speed)
        {
            long time = 0;
            foreach (var item in piles)
            {
                int curTime = item / speed;
                if (item % speed > 0)
                {
                    curTime++;
                }
                time += curTime;
            }
            return time;
        }
    }
}
