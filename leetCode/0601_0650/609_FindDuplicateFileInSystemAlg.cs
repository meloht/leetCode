using leetCode._1951_2000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0601_0650
{
    public class _609_FindDuplicateFileInSystemAlg
    {
        public IList<IList<string>> FindDuplicate(string[] paths)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            foreach (string path in paths)
            {
                string[] arr = path.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string pathVal = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    string name = getName(arr[i]);
                    string val = getContent(arr[i], name.Length);
                    if (!dict.ContainsKey(val))
                    {
                        dict[val] = new List<string>();

                    }
                    dict[val].Add($"{pathVal}/{name}");
                }

            }
            IList<IList<string>> res=new List<IList<string>>();

            foreach (var val in dict.Values)
            {
                if (val.Count > 1)
                {
                    res.Add(val);
                }
            }

            return res;
        }
        private string getName(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '(')
                {
                    sb.Append(s[i]);
                }
                else
                {
                    break;
                }
            }
            return sb.ToString();
        }
        private string getContent(string s, int skip)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = skip; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == ')')
                {
                    continue;
                }
                sb.Append(s[i]);
            }
            return sb.ToString();
        }
    }
}
