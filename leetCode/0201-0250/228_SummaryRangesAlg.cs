using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _228_SummaryRangesAlg
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            List<string> result = new List<string>();
            if (nums.Length == 0)
                return result;
            if (nums.Length == 1)
            {
                result.Add(nums[0].ToString());
                return result;
            }

            int begin = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                int curr = nums[i];
                if (nums[i - 1] + 1 != curr)
                {
                    if (begin == nums[i - 1])
                    {
                        result.Add(begin.ToString());
                    }
                    else
                    {
                        result.Add($"{begin}->{nums[i - 1]}");
                    }
                    begin = curr;
                }
              
                if (i == nums.Length - 1)
                {
                    if (nums[i - 1] + 1 != curr)
                    {
                        result.Add(curr.ToString());
                    }
                    else
                    {
                        result.Add($"{begin}->{curr}");
                    }
                }
            }
            return result;
        }

        public IList<string> SummaryRanges2(int[] nums)
        {
            List<string> result = new List<string>();
            int i = 0;
            int n = nums.Length;
            while (i < n)
            {
                int low = i;
                i++;
                while (i < n && nums[i] == nums[i - 1] + 1)
                {
                    i++;
                }
                int high = i - 1;
                StringBuilder temp = new StringBuilder();
                temp.Append(nums[low]);
                if (low < high)
                {
                    temp.Append("->");
                    temp.Append(nums[high]);
                }
                result.Add(temp.ToString());
            }
            return result;
        }


    }
}
