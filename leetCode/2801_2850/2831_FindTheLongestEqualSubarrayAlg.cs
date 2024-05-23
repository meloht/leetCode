using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._2801_2850
{
    public class _2831_FindTheLongestEqualSubarrayAlg
    {
        public int LongestEqualSubarray(IList<int> nums, int k)
        {
            int n = nums.Count;
            List<int>[] posLists = new List<int>[n + 1];
            for (int i = 0; i < posLists.Length; i++)
            {
                posLists[i] = new List<int>();
            }
            for (int i = 0; i < n; i++)
            {
                int x = nums[i];
                posLists[x].Add(i - posLists[x].Count);
            }

            int ans = 0;
            foreach (List<int> pos in posLists)
            {
                if (pos.Count <= ans)
                {
                    continue; // 无法让 ans 变得更大
                }
                int left = 0;
                for (int right = 0; right < pos.Count; right++)
                {
                    while (pos[right] - pos[left] > k)
                    { // 要删除的数太多了
                        left++;
                    }
                    ans = Math.Max(ans, right - left + 1);
                }
            }
            return ans;


        }
    }
}
