using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _229_MajorityElementIIAlg
    {
        public IList<int> MajorityElement(int[] nums)
        {
            List<int> result = new List<int>();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int n = nums.Length / 3;
            HashSet<int> visited = new HashSet<int>();
            foreach (var item in nums)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict.Add(item, 1);
                }
                if (dict[item] > n && visited.Add(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
