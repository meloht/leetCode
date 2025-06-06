using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2401_2450
{
    public class _2434_UsingARobotToPrintTheLexicographicallySmallestStringAlg
    {
        public string RobotWithString(string s)
        {
            int n = s.Length;
            int[] arrRight = new int[26];

            foreach (var item in s)
            {
                arrRight[item - 'a']++;
            }

            StringBuilder t = new StringBuilder();
            StringBuilder ans = new StringBuilder();
            int i = 0;
            int chIdx = 0;
            while (ans.Length < n)
            {
                int idx = GetMin(arrRight, chIdx);
                if (idx != -1)
                {

                    if (t.Length > 0 && t[t.Length - 1] - 'a' <= idx)
                    {
                        ans.Append(t[t.Length - 1]);
                        t.Remove(t.Length - 1, 1);
                    }
                    else
                    {
                        for (int j = i; j < s.Length; j++)
                        {
                            int index = s[j] - 'a';
                            arrRight[index]--;
                            if (index == idx)
                            {
                                chIdx = arrRight[index] == 0 ? idx + 1 : idx;
                                ans.Append(s[j]);

                                i = j + 1;
                                break;
                            }
                            t.Append(s[j]);

                        }
                    }
                }
                else
                {

                    for (int j = t.Length - 1; j >= 0; j--)
                    {
                        ans.Append(t[j]);
                    }
                }
            }

            return ans.ToString();
        }

        private int GetMin(int[] arr, int j)
        {
            for (int i = j; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
