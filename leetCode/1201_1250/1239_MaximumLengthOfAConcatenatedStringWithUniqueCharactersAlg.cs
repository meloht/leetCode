using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1201_1250
{
    public class _1239_MaximumLengthOfAConcatenatedStringWithUniqueCharactersAlg
    {
        int ans = 0;

        public int MaxLength(IList<string> arr)
        {
            IList<int> masks = new List<int>();
            foreach (string s in arr)
            {
                int mask = 0;
                foreach (char c in s)
                {
                    int ch = c - 'a';
                    if (((mask >> ch) & 1) != 0)
                    { // 若 mask 已有 ch，则说明 s 含有重复字母，无法构成可行解
                        mask = 0;
                        break;
                    }
                    mask |= 1 << ch; // 将 ch 加入 mask 中
                }
                if (mask > 0)
                {
                    masks.Add(mask);
                }
            }

            Backtrack(masks, 0, 0);
            return ans;
        }

        public void Backtrack(IList<int> masks, int pos, int mask)
        {
            if (pos == masks.Count)
            {
                ans = Math.Max(ans, BitCount(mask));
                return;
            }
            if ((mask & masks[pos]) == 0)
            { // mask 和 masks[pos] 无公共元素
                Backtrack(masks, pos + 1, mask | masks[pos]);
            }
            Backtrack(masks, pos + 1, mask);
        }

        private static int BitCount(int i)
        {
            i = i - ((i >> 1) & 0x55555555);
            i = (i & 0x33333333) + ((i >> 2) & 0x33333333);
            i = (i + (i >> 4)) & 0x0f0f0f0f;
            i = i + (i >> 8);
            i = i + (i >> 16);
            return i & 0x3f;
        }

    }
}
