using leetCode._1501_1550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1551_1600
{
    public class _1552_MagneticForceBetweenTwoBallsAlg
    {
        public int MaxDistance(int[] position, int m)
        {
            Array.Sort(position);
            int ans = 0;
            int left = 1;
            int right = position[position.Length - 1] - position[0];
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (Check(position, mid, m))
                {
                    ans = mid;
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return ans;
        }
        private bool Check(int[] position, int mid, int m)
        {
            int count = 1;
            int prev = position[0];
            for (int i = 1; i < position.Length; i++)
            {
                if (position[i] - prev >= mid)
                {
                    count++;
                    prev = position[i];
                    if (count >= m)
                    {
                        return true;
                    }
                }
            }
            return count >= m;
        }
    }
}
