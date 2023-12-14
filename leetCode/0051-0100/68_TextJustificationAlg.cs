using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _68_TextJustificationAlg
    {
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            List<string> list = new List<string>();
            List<string> lines = new List<string>();
            int len = 0;

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                int rest = maxWidth - len - lines.Count;
                if (rest >= 0 && word.Length <= rest)
                {
                    lines.Add(word);
                    len += word.Length;
                    if (i == words.Length - 1)
                    {
                        string ss = string.Join(" ", lines).PadRight(maxWidth, ' ');
                        list.Add(ss);
                        len = 0;
                        lines.Clear();
                    }
                }
                else
                {
                    if (lines.Count > 1)
                    {
                        list.Add(BuldLine(lines, maxWidth, len));
                        len = 0;
                        lines.Clear();
                    }
                    else
                    {
                        string ss = lines[0].PadRight(maxWidth, ' ');
                        list.Add(ss);
                        len = 0;
                        lines.Clear();
                    }
                    lines.Add(word);
                    len += word.Length;
                }
            }

            if (lines.Count > 0)
            {
                string ss = string.Join(" ", lines).PadRight(maxWidth, ' ');
                list.Add(ss);
                len = 0;
                lines.Clear();
            }


            return list;
        }

        private string BuldLine(List<string> lines, int maxWidth, int len)
        {
            int rest = maxWidth - len;
            int n = rest / (lines.Count - 1);
            int m = rest % (lines.Count - 1);
            int count = lines.Count - 1;
            Queue<string> blanks = new Queue<string>();
            for (int i = 0, j = 0; i < count; i++, j++)
            {
                int mm = n;
                if (j < m)
                {
                    mm += 1;
                }
                blanks.Enqueue("".PadLeft(mm, ' '));
            }
            StringBuilder sb = new StringBuilder();
            foreach (var item in lines)
            {
                sb.Append(item);
                if (blanks.Count > 0)
                {
                    string ss = blanks.Dequeue();
                    sb.Append(ss);
                }
            }
            return sb.ToString(); ;
        }
    }
}
