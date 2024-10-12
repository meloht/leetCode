using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3151_4000
{
    public class _3158_FindTheXorOfNumbersWhichAppearTwiceAlg
    {
        public int DuplicateNumbersXOR(int[] nums)
        {
            int[] arr = new int[51];

            foreach (var item in nums)
            {
                arr[item]++;
            }
            int ans = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 1)
                {
                    if (ans == 0)
                    {
                        ans = i;
                    }
                    else
                    {
                        ans = ans ^ i;
                    }
                }
            }
            return ans;
        }
    }
}
