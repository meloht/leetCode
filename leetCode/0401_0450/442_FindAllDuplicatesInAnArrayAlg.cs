using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _442_FindAllDuplicatesInAnArrayAlg
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int x = Math.Abs(nums[i]);
                if (nums[x - 1] > 0)
                {
                    nums[x - 1] = -nums[x - 1];
                }
                else
                {
                    result.Add(x);
                }
            }
            return result;
        }
    }
}
