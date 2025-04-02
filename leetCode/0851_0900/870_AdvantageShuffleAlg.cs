using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _870_AdvantageShuffleAlg
    {
        public int[] AdvantageCount(int[] nums1, int[] nums2)
        {
            int n = nums1.Length;

            int[] idx1 = new int[n];
            int[] idx2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                idx1[i] = i;
                idx2[i] = i;
            }

            Array.Sort(idx1, (x, y) => nums1[x] - nums1[y]);
            Array.Sort(idx2, (x, y) => nums2[x] - nums2[y]);

            int[] ans = new int[n];
            Array.Fill(ans, -1);

            for (int i = 0, j = 0, k = n - 1; i < n; i++)
            {
                int ii = idx1[i];
                int jj = idx2[j];

                if (nums1[ii] > nums2[jj])
                {
                    ans[jj] = nums1[ii];
                    j++;
                }
                else
                {
                    ans[idx2[k]] = nums1[ii];
                    k--;
                }
            }
            return ans;
        }
    }
}
