using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _165_CompareVersionNumbersAlg
    {
        public int CompareVersion(string version1, string version2)
        {
            int i = 0;

            string[] arr1 = version1.Split('.', StringSplitOptions.RemoveEmptyEntries);
            string[] arr2 = version2.Split('.', StringSplitOptions.RemoveEmptyEntries);
            int len1 = arr1.Length;
            int len2 = arr2.Length;
            while (i < len1 || i < len2)
            {
                if (i < len1 && i < len2)
                {
                    int v1 = GetNum(arr1[i].TrimStart('0'));
                    int v2 = GetNum(arr2[i].TrimStart('0'));
                    if (v1 > v2)
                        return 1;
                    if (v1 < v2)
                        return -1;
                }
                else if (i < len1)
                {
                    int v1 = GetNum(arr1[i].TrimStart('0'));
                    if (v1 > 0)
                        return 1;
                }
                else if (i < len2)
                {
                    int v1 = GetNum(arr2[i].TrimStart('0'));
                    if (v1 > 0)
                        return -1;
                }

                i++;
            }
            return 0;
        }
        private int GetNum(string s)
        {
            var res = s.TrimStart('0');
            if (res.Length == 0)
                return 0;
            return int.Parse(res);
        }
    }
}
