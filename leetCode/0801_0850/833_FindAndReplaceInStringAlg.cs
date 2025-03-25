using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _833_FindAndReplaceInStringAlg
    {
        public string FindReplaceString(string s, int[] indices, string[] sources, string[] targets)
        {
            StringBuilder sb = new StringBuilder();

            List<int>[] map = new List<int>[1000];


            for (int i = 0; i < indices.Length; i++)
            {
                int idx = indices[i];
                if (map[idx] == null)
                {
                    map[idx] = new List<int>();
                }
                map[idx].Add(i);
            }

            for (int i = 0; i < s.Length;)
            {
                bool bl = false;
                if (map[i] != null)
                {
                    var list = map[i];
                  
                    foreach (int j in list)
                    {
                        if (IsSame(s, i, sources[j]))
                        {
                            bl = true;
                            sb.Append(targets[j]);
                            i += sources[j].Length;
                            break;
                        }
                    }
                }

                if (!bl)
                {
                    sb.Append(s[i]);
                    i++;
                }
            }


            return sb.ToString();
        }
        private bool IsSame(string s, int idx, string t)
        {
            if (s.Length - idx < t.Length)
                return false;
            for (int i = idx, j = 0; i < s.Length && j < t.Length; i++, j++)
            {
                if (s[i] != t[j])
                {
                    return false;
                }
            }
            return true;
        }

    }
}
