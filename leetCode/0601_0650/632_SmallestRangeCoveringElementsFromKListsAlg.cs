using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace leetCode._0601_0650
{
    public class _632_SmallestRangeCoveringElementsFromKListsAlg
    {
        public int[] SmallestRange(IList<IList<int>> nums)
        {
            int n = 0;
            foreach (var item in nums)
            {
                n += item.Count;
            }


            List<int[]> ordered = new List<int[]>();

            for (int kk = 0; kk < nums.Count; kk++)
            {
                foreach (int item in nums[kk])
                {
                    ordered.Add([item, kk]);
                }
            }
            ordered.Sort((x, y) => x[0].CompareTo(y[0]));

            int i = 0, k = 0;

            int[] ans = [-1, -1];

            int[] count = new int[nums.Count];

            for (int j = 0; j < ordered.Count; j++)
            {
                if (count[ordered[j][1]]++ == 0)
                {
                    ++k;
                }
                if (k == nums.Count)
                {
                    while (count[ordered[i][1]] > 1)
                    {
                        --count[ordered[i++][1]];
                    }
                    if ((ans[0] == -1 && ans[1] == -1) || ans[1] - ans[0] > ordered[j][0] - ordered[i][0])
                    {
                        ans = [ordered[i][0], ordered[j][0]];
                    }



                }
            }


            return ans;
        }


    }
}
