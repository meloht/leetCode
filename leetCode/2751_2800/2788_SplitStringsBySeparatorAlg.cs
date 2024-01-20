using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2751_2800
{
    public class _2788_SplitStringsBySeparatorAlg
    {
        public IList<string> SplitWordsBySeparator(IList<string> words, char separator)
        {
            List<string> result = new List<string>();
            foreach (string word in words)
            {
                var ls = word.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                result.AddRange(ls);
            }
            return result;
        }
    }
}
