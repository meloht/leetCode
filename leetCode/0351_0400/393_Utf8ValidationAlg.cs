using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _393_Utf8ValidationAlg
    {
        public bool ValidUtf8(int[] data)
        {

            for (int i = 0; i < data.Length; i++)
            {
                string ss = Convert.ToString(data[i], 2).PadLeft(8, '0');
                if (ss.StartsWith('0'))
                {
                    continue;
                }
                else
                {
                    int num = 0;

                    for (int j = 0; j < ss.Length; j++)
                    {
                        if (ss[j] == '1')
                        {
                            num++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (num == ss.Length || num == 1 || num > 4)
                    {
                        return false;
                    }
                    int end = num + i;
                    if (end > data.Length)
                    {
                        return false;
                    }
                    for (int j = i + 1; j < end; j++)
                    {
                        string sss = Convert.ToString(data[j], 2).PadLeft(8, '0');
                        if (!sss.StartsWith("10"))
                        {
                            return false;
                        }
                    }
                    i = i + num - 1;
                }
            }
            return true;
        }
    }
}
