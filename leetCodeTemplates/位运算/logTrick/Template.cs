using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeTemplates.位运算.logTrick
{
    public class Template
    {
        public int[] logTrick(int[] nums)
        {
            int n = nums.Length;
            int[] ans = new int[n];
            List<int[]> ors = new List<int[]>();

            for (int i = n - 1; i >= 0; i--)
            {
                ors.Add([0, i]);
                int k = 0;
                foreach (var item in ors)
                {
                    item[0] |= nums[i];
                    if (ors[k][0] == item[0])
                    {
                        ors[k][1] = item[1];
                    }
                    else
                    {
                        k++;
                        ors[k] = item;

                    }
                }
                ors.RemoveRange(k + 1, ors.Count - k - 1);
                ans[i] = ors[0][1] - i + 1;
            }


            return ans;
        }
    }
}
