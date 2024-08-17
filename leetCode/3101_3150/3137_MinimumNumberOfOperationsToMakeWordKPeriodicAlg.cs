using leetCode._3051_3100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3101_3150
{
    public class _3137_MinimumNumberOfOperationsToMakeWordKPeriodicAlg
    {
        public int MinimumOperationsToMakeKPeriodic(string word, int k)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < word.Length; i += k)
            {
                string s = word.Substring(i, k);
                if (dict.ContainsKey(s))
                {
                    dict[s]++;
                }
                else
                {
                    dict.Add(s, 1);
                }
            }
            int max = dict.Values.Max();
            int ans = word.Length / k - max;
            return ans;
        }
    }
}
