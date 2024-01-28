using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    public class _763_PartitionLabelsAlg
    {
        public IList<int> PartitionLabels1(string s)
        {
            List<int> res = new List<int>();
            int i = 0;
            int count = 0;
            HashSet<char> set = new HashSet<char>();
            while (i < s.Length)
            {
                count++;
                var ch = s[i];
                if (!set.Contains(ch))
                {
                    set.Add(ch);

                }

                bool bl = true;
                for (int k = i + 1; k < s.Length; k++)
                {
                    var ch2 = s[k];
                    if (set.Contains(ch2))
                    {
                        bl = false;
                        break;
                    }

                }
                if (bl)
                {
                    res.Add(count);
                    set.Clear();
                    count = 0;
                }

                i++;

            }
            return res;
        }

        public IList<int> PartitionLabels(string s)
        {
            List<int> res = new List<int>();

            int[] arr = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                int index = s[i] - 'a';
                arr[index] = i;
            }
            int start = 0;
            int end = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int index = s[i] - 'a';
                end = Math.Max(end, arr[index]);
                if (end == i)
                {
                    res.Add(end - start + 1);
                    start = end + 1;
                }

            }

            return res;
        }
    }
}
