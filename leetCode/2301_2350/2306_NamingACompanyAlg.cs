using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2301_2350
{
    public class _2306_NamingACompanyAlg
    {
        public long DistinctNames(string[] ideas)
        {
            Dictionary<char,HashSet<string>> dict=new Dictionary<char, HashSet<string>>();
            foreach (string idea in ideas) 
            {
                dict.TryAdd(idea[0], new HashSet<string>());
                dict[idea[0]].Add(idea.Substring(1));
            }
            long ans = 0;
            foreach (KeyValuePair<char, HashSet<string>> pairA in dict)
            {
                char preA = pairA.Key;
                ISet<string> setA = pairA.Value;
                foreach (KeyValuePair<char, HashSet<string>> pairB in dict)
                {
                    char preB = pairB.Key;
                    ISet<string> setB = pairB.Value;
                    if (preA == preB)
                    {
                        continue;
                    }
                    int intersect = GetIntersectSize(setA, setB);
                    ans += (long)(setA.Count - intersect) * (setB.Count - intersect);
                }
            }
            return ans;


        }
        public int GetIntersectSize(ISet<string> a, ISet<string> b)
        {
            int ans = 0;
            foreach (string s in a)
            {
                if (b.Contains(s))
                {
                    ans++;
                }
            }
            return ans;
        }

    }
}
