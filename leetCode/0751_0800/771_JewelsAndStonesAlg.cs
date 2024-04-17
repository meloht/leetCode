using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    public class _771_JewelsAndStonesAlg
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            HashSet<char> set=new HashSet<char>(jewels);
            int ans = 0;
            foreach (var item in stones)
            {
                if (set.Contains(item))
                {
                    ans++;
                }
            }
            return ans;
        }
    }
}
