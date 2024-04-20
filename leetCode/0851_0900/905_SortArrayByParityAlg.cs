using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _905_SortArrayByParityAlg
    {
        public int[] SortArrayByParity(int[] nums)
        {
            List<int> result1 = new List<int>();
            List<int> result2 = new List<int>();
            foreach (var item in nums)
            {
                if (item % 2 == 0)
                {
                    result1.Add(item);
                }
                else
                {
                    result2.Add(item);
                }
            }
            result1.AddRange(result2);
            return result1.ToArray();
        }
    }
}
