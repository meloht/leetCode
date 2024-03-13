using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1351_1400
{
    public class _1351_CountNegativeNumbersInASortedMatriAlg
    {
        public int CountNegatives1(int[][] grid)
        {
            int ans = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                int[] nums = grid[i];
                if (nums[nums.Length - 1] >= 0)
                {
                    continue;
                }
                if (nums[0] < 0)
                {
                    ans += nums.Length;
                }
                else
                {
                    int col1 = BinarySearch(nums);
                    ans += (nums.Length - col1);
                }

            }
            return ans;
        }

        public int CountNegatives(int[][] grid)
        {
            int ans = 0;
            int rows = grid.Length;
            int cols = grid[0].Length;
            for (int i = rows - 1; i >= 0; i--)
            {
                for (int j = cols - 1; j >= 0; j--)
                {
                    if (grid[i][j] >= 0)
                        break;
                    ans++;
                }

            }
            return ans;
        }
        public int BinarySearch(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                int mid = (right - left) / 2 + left;
                if (nums[mid] < 0)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return right;
        }
        private int BinarySearchCol(int[][] grid, int col)
        {
            int left = 0;
            int right = grid[col].Length - 1;
            while (left < right)
            {
                int mid = (right - left) / 2 + left;
                if (grid[mid][col] < 0)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return right;
        }


    }
}
