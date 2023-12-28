using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _169_MajorityElementAlg
    {
        public int MajorityElement2(int[] nums)
        {
            int n = nums.Length / 2;
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (int i in nums)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;

                }
                else
                {
                    dict.Add(i, 1);
                }
                if (dict[i] > n)
                    return i;
            }
            return 0;
        }

        public int MajorityElement1(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];
            int n = nums.Length / 2;
            Array.Sort(nums);

          
            return nums[n];
        }

        public int MajorityElement(int[] nums)
        {
            int temp = 0;
            int count = 0;
            foreach (int i in nums) 
            {
                if (count == 0)
                {
                    temp = i;
                }
                if (temp == i)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
            
            return temp;
        }
    }
}
