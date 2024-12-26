using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3051_3100
{
    public class _3083_ExistenceOfASubstringInAStringAndItsReverseAlg
    {
        public bool IsSubstringPresent(string s)
        {
            if (s.Length < 2)
                return false;
            HashSet<string> dict = new HashSet<string>();
            char[] arr = new char[2];
            arr[0] = s[0];
            arr[1] = s[1];
            if (arr[0] == arr[1])
                return true;

            dict.Add(new string(arr));

            for (int i = 2; i < s.Length; i++)
            {

                arr[1] = s[i];
                arr[0] = s[i - 1];

                if (arr[0] == arr[1])
                    return true;

                string ss = new string([arr[1], arr[0]]);
                if (dict.Contains(ss))
                {
                    return true;
                }
                dict.Add(new string(arr));
            }


            return false;
        }
    }
}
