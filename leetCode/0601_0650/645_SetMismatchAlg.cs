using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0601_0650
{
    public class _645_SetMismatchAlg
    {
        public int[] FindErrorNums(int[] nums)
        {
            Dictionary<int, int> set = new Dictionary<int, int>();
            int[] result = new int[2];
            foreach (int num in nums) 
            {
                if (set.ContainsKey(num))
                {
                    set[num]++;
                }
                else
                {
                    set.Add(num, 1);
                }
            }
            for (int i = 1; i <= nums.Length; i++)
            {
                if (!set.ContainsKey(i))
                {
                    result[1] = i;
                }
                else if (set[i]>1) 
                {
                    result[0] = i;
                }
            }
            return result;
        }
    }
}
