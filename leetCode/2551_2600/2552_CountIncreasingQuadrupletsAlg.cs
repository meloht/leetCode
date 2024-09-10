using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2551_2600
{
    public class _2552_CountIncreasingQuadrupletsAlg
    {
        public long CountQuadruplets1(int[] nums)
        {
            int n = nums.Length;
            int[][] great = new int[n][];
            for (int i = 0; i < n; i++)
            {
                great[i] = new int[n + 1];
            }

            for (int k = n - 2; k >= 2; k--)
            {
                Array.Copy(great[k + 1], great[k], great[k].Length);
                for (int i = 1; i < nums[k + 1]; i++)
                {
                    great[k][i]++;
                }
            }

            long ans = 0;
            int[] less = new int[n + 1];
            for (int j = 1; j < n - 2; j++)
            {
                for (int x = nums[j - 1] + 1; x <= n; x++)
                {
                    less[x]++;
                }
                for (int k = j + 1; k < n - 1; k++)
                {
                    if (nums[j] > nums[k])
                    {
                        ans += less[nums[k]] * great[k][nums[j]];
                    }
                }
            }

            return ans;
        }

        public long CountQuadruplets(int[] nums)
        {
            int n = nums.Length;
            int[][] great = new int[n][];
            for (int i = 0; i < n; i++)
            {
                great[i] = new int[n + 1];
            }

            for (int k = n - 2; k >= 0; k--)
            {
                Array.Copy(great[k + 1], great[k], great[k].Length);
                for (int i = 1; i < nums[k + 1]; i++)
                {
                    great[k][i]++;
                }
            }

            long ans = 0;
            for (int j = 1; j < n - 2; j++)
            {
                for (int k = j + 1; k < n - 1; k++)
                {
                    int x = nums[k];
                    if (nums[j] > x)
                    {
                        ans += (x - n + 1 + j + great[j][x]) * great[k][nums[j]];
                    }
                }
            }

            return ans;
        }
    }
}
