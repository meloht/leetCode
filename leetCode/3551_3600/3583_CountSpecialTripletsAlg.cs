using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3551_3600
{
    public class _3583_CountSpecialTripletsAlg
    {
        public int SpecialTriplets(int[] nums)
        {
            int mod = 1_000_000_007;
            Dictionary<int, int> dictSuf = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (dictSuf.ContainsKey(item))
                {
                    dictSuf[item]++;
                }
                else
                {
                    dictSuf.Add(item, 1);
                }
            }
            long ans = 0;
            Dictionary<int, int> dictPre = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (dictSuf.ContainsKey(item))
                {
                    dictSuf[item]--;
                }
                if (dictPre.ContainsKey(item * 2) && dictSuf.ContainsKey(item * 2))
                {
                    ans += (long)dictPre[item * 2] * (long)dictSuf[item * 2];
                }

                if (dictPre.ContainsKey(item))
                {
                    dictPre[item]++;
                }
                else
                {
                    dictPre.Add(item, 1);
                }
            }
            return (int)(ans % mod);
        }
    }
}
