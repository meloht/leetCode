using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2651_2700
{
    public class _2696_MinimumStringLengthAfterRemovingSubstringsAlg
    {
        public int MinLength1(string s)
        {
            string ab = "AB";
            string cd = "CD";
            string ans = s;
            int index1 = ans.IndexOf(ab);
            int index2 = ans.IndexOf(cd);
            StringBuilder sb = new StringBuilder();
            while (index1 != -1 || index2 != -1)
            {
              
                for (int i = 0; i < ans.Length; i++)
                {
                    if (index1 != -1)
                    {
                        if (i >= index1 && i <= (index1 + 1))
                        {
                            continue;
                        }
                       
                    }

                    if (index2 != -1)
                    {
                        if (i >= index2 && i <= (index2 + 1))
                        {
                            continue;
                        }
                    }

                    sb.Append(ans[i]);
                }

                ans = sb.ToString();
                sb.Clear();

                index1 = ans.IndexOf(ab);
                index2 = ans.IndexOf(cd);
            }

            return ans.Length;
        }

        public int MinLength(string s)
        {
            IList<char> stack = new List<char>();
            foreach (char c in s)
            {
                stack.Add(c);
                int m = stack.Count;
                if (m >= 2 &&
                    (stack[m - 2] == 'A' && stack[m - 1] == 'B' || stack[m - 2] == 'C' && stack[m - 1] == 'D'))
                {
                    stack.RemoveAt(m - 1);
                    stack.RemoveAt(m - 2);
                }
            }
            return stack.Count;
        }


    }
}
