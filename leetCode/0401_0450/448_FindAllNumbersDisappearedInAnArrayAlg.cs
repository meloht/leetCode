using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _448_FindAllNumbersDisappearedInAnArrayAlg
    {
        public IList<int> FindDisappearedNumbers1(int[] nums)
        {
            List<int> list = new List<int>();
            HashSet<int> set = new HashSet<int>(nums);
            for (int i = 1; i <= nums.Length; i++)
            {
                if (!set.Contains(i))
                {
                    list.Add(i);
                }
            }
            return list;
        }

        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            List<int> list = new List<int>();
            foreach (var item in nums)
            {
                int n = (item - 1) % nums.Length;
                nums[n] += nums.Length;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= nums.Length)
                {
                    list.Add(i + 1);
                }
            }
            return list;
        }
    }
}
