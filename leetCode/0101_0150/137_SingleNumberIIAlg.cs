using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _137_SingleNumberIIAlg
    {
        public int SingleNumber(int[] nums)
        {
            Dictionary<int, int> set = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!set.ContainsKey(nums[i]))
                {
                    set.Add(nums[i], 0);
                }
                set[nums[i]]++;
            }
            foreach (var item in set)
            {
                if (item.Value == 1)
                {
                    return item.Key;
                }
            }
            return 0;
        }
    }
}
