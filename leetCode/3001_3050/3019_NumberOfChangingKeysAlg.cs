using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3001_3050
{
    public class _3019_NumberOfChangingKeysAlg
    {
        public int CountKeyChanges(string s)
        {
            int ans = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (char.ToLower(s[i - 1]) != char.ToLower(s[i]))
                {
                    ans++;
                }
            }

            return ans;
        }
    }
}
