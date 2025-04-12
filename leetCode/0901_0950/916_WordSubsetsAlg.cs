using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _916_WordSubsetsAlg
    {
        public IList<string> WordSubsets(string[] words1, string[] words2)
        {

            int[] arr = new int[26];
            foreach (var word in words2)
            {
                int[] map = new int[26];
                foreach (var item in word)
                {
                    map[item - 'a']++;
                }
                for (int i = 0; i < 26; i++)
                {
                    arr[i] = Math.Max(map[i], arr[i]);
                }
            }
            List<string> ans = new List<string>();
            foreach (var word in words1)
            {
                int[] map = new int[26];
                foreach (var item in word)
                {
                    map[item - 'a']++;
                }
                bool bl = true;
                for (int i = 0; i < 26; i++)
                {
                    if (arr[i] > map[i])
                    {
                        bl = false;
                        break;
                    }
                }
                if (bl)
                {
                    ans.Add(word);
                }
            }
            return ans;
        }
    }
}
