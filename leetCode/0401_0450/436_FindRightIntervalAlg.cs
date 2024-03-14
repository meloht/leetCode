using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _436_FindRightIntervalAlg
    {
        public int[] FindRightInterval(int[][] intervals)
        {
            int[][] nums=new int[intervals.Length][];
            for (int i = 0; i < intervals.Length; i++)
            {
                nums[i] = [intervals[i][0], i];
            }
            Array.Sort(nums, (x, y) => x[0].CompareTo(y[0]));

            int[] result = new int[nums.Length];

            for (int i = 0; i < intervals.Length; i++)
            {
              
              
            }

            return result;
        }
       
    }
}
