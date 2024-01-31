using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1501_1550
{
    public class _1512_NumberOfGoodPairsAlg
    {
        public int NumIdenticalPairs(int[] nums)
        {
            int ans = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                if (dict.ContainsKey(num))
                {
                    ans += dict[num];
                    dict[num]++;
                }
                else
                {
                    dict.Add(num, 1);
                }

            }
            return ans;
        }
    }
}
