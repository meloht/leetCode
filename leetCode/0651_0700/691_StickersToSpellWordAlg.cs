using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _691_StickersToSpellWordAlg
    {
        public int MinStickers(string[] stickers, string target)
        {
            Dictionary<char,int> dict=new Dictionary<char, int>();
            foreach (var item in target)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }

            return 0;
        }


    }
}
