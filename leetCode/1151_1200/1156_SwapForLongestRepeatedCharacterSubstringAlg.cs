using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1151_1200
{
    public class _1156_SwapForLongestRepeatedCharacterSubstringAlg
    {
        public int MaxRepOpt1(string text)
        {
            Dictionary<char, int> count = new Dictionary<char, int>();
            foreach (char c in text)
            {
                count.TryAdd(c, 0);
                count[c]++;
            }

            int res = 0;
            for (int i = 0; i < text.Length;)
            {
                // step1: 找出当前连续的一段 [i, j)
                int j = i;
                while (j < text.Length && text[j] == text[i])
                {
                    j++;
                }
                int curCnt = j - i;

                // step2: 如果这一段长度小于该字符出现的总数，并且前面或后面有空位，则使用 curCnt + 1 更新答案
                if (curCnt < (count.ContainsKey(text[i]) ? count[text[i]] : 0) && (j < text.Length || i > 0))
                {
                    res = Math.Max(res, curCnt + 1);
                }

                // step3: 找到这一段后面与之相隔一个不同字符的另一段 [j + 1, k)，如果不存在则 k = j + 1 
                int k = j + 1;
                while (k < text.Length && text[k] == text[i])
                {
                    k++;
                }
                res = Math.Max(res, Math.Min(k - i, count.ContainsKey(text[i]) ? count[text[i]] : 0));
                i = j;
            }
            return res;

        }
    }
}
