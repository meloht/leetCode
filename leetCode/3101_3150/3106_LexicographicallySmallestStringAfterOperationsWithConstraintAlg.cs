using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3101_3150
{
    public class _3106_LexicographicallySmallestStringAfterOperationsWithConstraintAlg
    {
        public string GetSmallestString(string s, int k)
        {
            char[] arr=s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                char ch = arr[i];
                int dis = Math.Min(ch - 'a', 'z' - ch + 1);
                if (dis > k)
                {
                    arr[i] = (char)(arr[i] - k);
                    break;
                }
                arr[i] = 'a';
                k -= dis;
            }
            return new string(arr);
        }
    }
}
