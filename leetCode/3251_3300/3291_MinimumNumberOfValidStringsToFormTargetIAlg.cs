using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3251_3300
{
    public class _3291_MinimumNumberOfValidStringsToFormTargetIAlg
    {
        public int MinValidStrings(string[] words, string target)
        {
            int n = target.Length;
            int[] maxJumps = new int[n];
            foreach (string word in words)
            {
                int[] z = calcZ(word + "#" + target);
                int m = word.Length + 1;
                for (int i = 0; i < n; i++)
                {
                    maxJumps[i] = Math.Max(maxJumps[i], z[m + i]);
                }
            }
            return jump(maxJumps);

        }

        private int[] calcZ(string S)
        {
            char[] s = S.ToCharArray();
            int n = s.Length;
            int[] z = new int[n];
            int boxL = 0;
            int boxR = 0; // z-box 左右边界（闭区间）
            for (int i = 1; i < n; i++)
            {
                if (i <= boxR)
                {
                    z[i] = Math.Min(z[i - boxL], boxR - i + 1);
                }
                while (i + z[i] < n && s[z[i]] == s[i + z[i]])
                {
                    boxL = i;
                    boxR = i + z[i];
                    z[i]++;
                }
            }
            return z;
        }

        private int jump(int[] maxJumps)
        {
            int ans = 0;
            int curR = 0; // 已建造的桥的右端点
            int nxtR = 0; // 下一座桥的右端点的最大值
            for (int i = 0; i < maxJumps.Length; i++)
            {
                nxtR = Math.Max(nxtR, i + maxJumps[i]);
                if (i == curR)
                { // 到达已建造的桥的右端点
                    if (i == nxtR)
                    { // 无论怎么造桥，都无法从 i 到 i+1
                        return -1;
                    }
                    curR = nxtR; // 造一座桥
                    ans++;
                }
            }
            return ans;
        }



     


    }

}
