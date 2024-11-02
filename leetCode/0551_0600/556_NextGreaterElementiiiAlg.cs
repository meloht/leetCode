using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0551_0600
{
    public class _556_NextGreaterElementiiiAlg
    {
        public int NextGreaterElement(int n)
        {
            string s = n.ToString();
            var ss = s.ToCharArray();

            int i = ss.Length - 2;
            while (i >= 0 && ss[i] >= ss[i + 1])
            {
                i--;
            }
            if (i < 0)
                return -1;

            int j = ss.Length - 1;

            while (j >= 0 && ss[i] >= ss[j])
            {
                j--;
            }
            Swap(ss, i, j);
            Reverse(ss, i + 1);
            string s1 = new string(ss);
            if (s1 == s)
            {
                return -1;
            }
            long val = long.Parse(s1);
            if (val > int.MaxValue)
                return -1;

            return (int)val;
        }

        public void Reverse(char[] nums, int begin)
        {
            int i = begin, j = nums.Length - 1;
            while (i < j)
            {
                Swap(nums, i, j);
                i++;
                j--;
            }
        }

        public void Swap(char[] nums, int i, int j)
        {
            char temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }


    }
}
