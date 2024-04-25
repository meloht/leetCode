using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1051_1100
{
    public class _1051_HeightCheckerAlg
    {
        public int HeightChecker(int[] heights)
        {
            int[] ans = new int[heights.Length];
            heights.CopyTo(ans, 0);
            Array.Sort(ans);
            int count = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] != ans[i])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
