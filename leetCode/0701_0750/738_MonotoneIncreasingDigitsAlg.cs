using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _738_MonotoneIncreasingDigitsAlg
    {
        public int MonotoneIncreasingDigits(int n)
        {
            if (n < 10)
                return n;

            string ss = n.ToString();

            int idx = 0;
            bool bl = false;
            for (int i = 0; i < ss.Length - 1; i++)
            {
                if (ss[i] < ss[i + 1])
                {
                    idx = i + 1;
                }
                if (ss[i] > ss[i + 1])
                {
                    bl = true;
                    break;

                }

            }
            if (bl)
            {
                int num = 0;
                int step = 1;
                int count = ss.Length - 1 - idx;
                for (int i = 0; i < count; i++)
                {
                    num += step * 9;
                    step *= 10;
                }
                if (ss[idx] > '1')
                {
                    num += step * (ss[idx] - '0' - 1);
                    step *= 10;
                }

                for (int i = idx - 1; i >= 0; i--)
                {
                    num += step * (ss[i] - '0');
                    step *= 10;
                }
                return num;
            }
            return n;
        }


        int res = 0;
        public int MonotoneIncreasingDigits1(int n)
        {
            string ss = n.ToString();
            List<int> ans = new List<int>();
            int nn = ss[0] - '0';
            ans.Add(nn);
            bool bl = Dfs(ss, nn, 1, ans);
            ans.Clear();
            if (!bl)
            {
                if (nn - 1 > 0)
                {
                    ans.Add(nn - 1);
                }
                AddTop(ans, 9, ss.Length - 1);
            }
            return res;
        }

        public bool Dfs(string ss, int prev, int idx, List<int> ans)
        {
            if (idx >= ss.Length)
                return true;
            int num = ss[idx] - '0';

            if (idx == ss.Length - 1)
            {
                if (num >= prev)
                {
                    ans.Add(num);
                    res = GetNum(ans);
                    return true;
                }
                return false;
            }

            if (num >= prev)
            {
                ans.Add(num);
                bool bl = Dfs(ss, num, idx + 1, ans);
                ans.RemoveAt(ans.Count - 1);
                if (bl)
                {
                    return true;
                }
                if (num > prev)
                {
                    if (num - 1 > 0)
                    {
                        ans.Add(num - 1);
                    }

                    AddTop(ans, 9, ss.Length - idx - 1);
                    return true;
                }
            }
            return false;
        }

        public int GetNum(List<int> ans)
        {
            int num = 0;
            for (int i = ans.Count - 1, j = 1; i >= 0; i--, j *= 10)
            {
                num += j * ans[i];
            }
            return num;
        }

        public void AddTop(List<int> ans, int val, int count)
        {
            for (int i = 0; i < count; i++)
            {
                ans.Add(9);
            }
            res = GetNum(ans);
        }
    }
}
