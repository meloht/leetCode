using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0601_0650
{
    public class _648_ReplaceWordsAlg
    {

        public string ReplaceWords(IList<string> dictionary, string sentence)
        {
            HashSet<string> words = new HashSet<string>(dictionary);
          
            var ls = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sb = new StringBuilder();
            foreach (var item in ls)
            {
                StringBuilder sbb = new StringBuilder();
                for (int i = 0; i < item.Length; i++)
                {
                    sbb.Append(item[i]);
                    var prefix = sbb.ToString();
                    if (words.Contains(prefix))
                    {
                        break;
                    }
                }
                sb.Append(sbb.ToString()).Append(" ");
            }

            return sb.ToString().Trim();
        }




    }
}
