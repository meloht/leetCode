using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.WeeklyContest._400
{
    public class Alg_400_04
    {
        public int MinimumDifference1(int[] nums, int k)
        {
            int ans = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                int x = nums[i];
                ans = Math.Min(ans, Math.Abs(x - k));
                for (int j = i - 1; j >= 0 && (nums[j] & x) != nums[j]; j--)
                {
                    nums[j] &= x;
                    ans = Math.Min(ans, Math.Abs(nums[j] - k));
                }
            }

            return ans;
        }

        public int MinimumDifference(int[] nums, int k)
        {
            List<int> list = new List<int>();
            int ans = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                list.Add(nums[i]);
                List<int> ls=new List<int>();

                foreach (var item in list)
                {
                    int num = item & nums[i];
                    if (ls.Count > 0 && ls[ls.Count - 1] == num)
                    {
                        continue;
                    }
                    ls.Add(num);
                }
                list = ls;
                foreach (var item in list)
                {
                    int d = Math.Abs(item - k);
                    if (ans == int.MaxValue || ans > d)
                    {
                        ans = d;
                    }
                }
            }

            return ans;
        }
    }
}
