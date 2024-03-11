using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2101_2150
{
    public class _2129_CapitalizeTheTitleAlg
    {
        public string CapitalizeTitle(string title)
        {
            string tt = title.ToLower();

            char[] chars = new char[tt.Length];

            int i = 0;
            while (i < tt.Length)
            {
                int begin = i;
                int count = 0;
                while (i < tt.Length && tt[i] != ' ')
                {
                    chars[i] = tt[i];
                    count++;
                    i++;
                }
                if (count > 2)
                {
                    chars[begin] = char.ToUpper(chars[begin]);
                }
                if (i < tt.Length)
                {
                    chars[i] = tt[i];
                }

                i++;

            }
            return new string(chars);
        }
    }
}
