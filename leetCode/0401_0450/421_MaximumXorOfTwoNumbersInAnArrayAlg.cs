using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _421_MaximumXorOfTwoNumbersInAnArrayAlg
    {
        public int FindMaximumXOR(int[] nums)
        {
            int max = nums.Max();
            int highBit = 31 - int.LeadingZeroCount(max);
            int ans = 0;
            int mask = 0;
            HashSet<int> set = new HashSet<int>();
            for (int i = highBit; i >= 0; i--)
            {
                set.Clear();
                mask |= (1 << i);
                int newAns = ans | (1 << i);

                foreach (int item in nums)
                {
                    int x = item;
                    x &= mask;
                    if (set.Contains(newAns ^ x))
                    {
                        ans = newAns;
                        break;
                    }
                    set.Add(x);
                }
            }
            return ans;
        }
    }
}
