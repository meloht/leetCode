using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _722_RemoveCommentsAlg
    {
        public IList<string> RemoveComments(string[] source)
        {
            List<string> list = new List<string>();

            bool bl = false;
            StringBuilder sb = new StringBuilder();
            foreach (string s in source)
            {
                bool bl2 = false;

                for (int i = 0; i < s.Length; i++)
                {
                    if (!bl && !bl2)
                    {
                        if (i + 1 < s.Length && s[i] == '/' && s[i + 1] == '*')
                        {
                            bl = true;
                            i++;
                        }
                        else if (i + 1 < s.Length && s[i] == '/' && s[i + 1] == '/')
                        {
                            bl2 = true;
                            i++;
                        }
                        else
                        {

                            sb.Append(s[i]);
                        }
                    }
                    else if (bl)
                    {
                        if (i + 1 < s.Length && s[i] == '*' && s[i + 1] == '/')
                        {
                            bl = false;
                            i++;
                        }
                    }
                }

                if (!bl && sb.Length > 0)
                {
                    list.Add(sb.ToString());
                    sb.Clear();
                }


            }

            return list;
        }
    }
}
