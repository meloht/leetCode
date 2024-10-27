using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _546_RemoveBoxesAlg
    {
        int[][][] dp;
        public int RemoveBoxes(int[] boxes)
        {
            int length = boxes.Length;
            dp = new int[length][][];
            for (int i = 0; i < length; i++)
            {
                dp[i] = new int[length][];
                for (int j = 0; j < length; j++)
                {
                    dp[i][j] = new int[length];
                }

            }
            return calculatePoints(boxes, 0, length - 1, 0);

        }

        public int calculatePoints(int[] boxes, int l, int r, int k)
        {
            if (l > r)
            {
                return 0;
            }
            if (dp[l][r][k] == 0)
            {
                int r1 = r, k1 = k;
                while (r1 > l && boxes[r1] == boxes[r1 - 1])
                {
                    r1--;
                    k1++;
                }
                dp[l][r][k] = calculatePoints(boxes, l, r1 - 1, 0) + (k1 + 1) * (k1 + 1);
                for (int i = l; i < r1; i++)
                {
                    if (boxes[i] == boxes[r1])
                    {
                        dp[l][r][k] = Math.Max(dp[l][r][k], calculatePoints(boxes, l, i, k1 + 1) + calculatePoints(boxes, i + 1, r1 - 1, 0));
                    }
                }
            }
            return dp[l][r][k];
        }


    }
}
