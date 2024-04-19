using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _844_BackspaceStringCompareAlg
    {
        public bool BackspaceCompare(string s, string t)
        {
            string s1 = GetStr(s);
            string t1 = GetStr(t);

            return s1 == t1;
        }
        private string GetStr(string s)
        {
            List<char> st = new List<char>();
            foreach (var item in s)
            {
                if (item == '#')
                {
                    if (st.Count > 0)
                    {
                        st.RemoveAt(st.Count - 1);
                    }
                }
                else
                {
                    st.Add(item);
                }
            }

            return new string(st.ToArray());
        }
    }
}
