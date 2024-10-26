using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _532_KDiffPairsInAnArrayAlg
    {
        public int FindPairs(int[] nums, int k)
        {

            HashSet<int> visited = new HashSet<int>();
            HashSet<int> res = new HashSet<int>();
            foreach (int num in nums)
            {
                if (visited.Contains(num - k))
                {
                    res.Add(num - k);
                }
                if (visited.Contains(num + k))
                {
                    res.Add(num);
                }
                visited.Add(num);
            }
            return res.Count;


        }
    }
}
